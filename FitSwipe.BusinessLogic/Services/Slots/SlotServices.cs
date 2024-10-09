using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Dtos.Trainings;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;
using System.Data.Entity;

namespace FitSwipe.BusinessLogic.Services.Slots
{
    public class SlotServices : ISlotServices
    {
        private readonly ISlotRepository _slotRepository;
        private readonly IUserServices _userServices;
        private readonly ITrainingService _trainingService;
        public SlotServices(ISlotRepository slotRepository, IUserServices userServices, ITrainingService trainingService)
        {
            _userServices = userServices;
            _slotRepository = slotRepository;
            _trainingService = trainingService;
        }

        public async Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel)
        {
            return (await _slotRepository.GetSlots(pagingModel)).Adapt<PagedResult<GetSlotDto>>();
        }

        public async Task<List<GetSlotDto>> CreateFreeSlotForPTAsync(List<CreateSlotDtos> model, string currentUserId)
        {

            //NOTE: Nên giới hạn độ dài của slot
            var currPTEntity = await _userServices.GetUserByIdRequiredAsync(currentUserId);
            // check user create is PT or not
            if (currPTEntity.Role != Role.PT)
            {
                throw new ModelException("PT", "You are not PT");
            }

            if (HasOverlappingSlots(model.Adapt<List<Slot>>()))
            {
                throw new BadRequestException("There are overlapping slots in the request!");
            }
            var slots = new List<Slot>();
            foreach (var slot in model)
            {
                if (slot.StartTime >= slot.EndTime)
                {
                    throw new BadRequestException("Slot startime must smaller than endtime");
                }
                // check slot time is dupplicate or not
                if (await IsSlotTimeDupplicatedForPT(slot.StartTime, slot.EndTime, currentUserId))
                {
                    throw new ModelException("Slot", " Time of Slot is Dupplicated");
                }
                var newSlot = new Slot()
                {
                    StartTime = DateTime.SpecifyKind(slot.StartTime, DateTimeKind.Utc),
                    EndTime = DateTime.SpecifyKind(slot.EndTime, DateTimeKind.Utc),
                    CreateById = currPTEntity.FireBaseId,
                    Type = SlotType.Free,
                    Status = SlotStatus.Unbooked
                };
                slots.Add(newSlot);
            }

            var resultSLot = await _slotRepository.AddRangeAsync(slots);
            if (resultSLot == null)
            {
                throw new ModelException("Slot", "error when adding slot");
            }
            return resultSLot.Adapt<List<GetSlotDto>>();
        }

        public async Task<List<GetSlotDto>> CreateTrainingSlot(List<CreateTrainingSlotDto> request, Guid trainingId, string currentUserId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(currentUserId);
            // check user create is PT or not
            if (user.Role != Role.Trainee)
            {
                throw new ModelException("PT", "This feature only support Trainees");
            }
            //Check training
            var training = await _trainingService.GetDetailById(trainingId);

            //var newSlot = model.Adapt<Slot>();
            if (HasOverlappingSlots(request.Adapt<List<Slot>>()))
            {
                throw new BadRequestException("There are overlapping slots in the request!");
            }
            var slots = new List<Slot>();
            foreach (var slot in request)
            {
                if (slot.StartTime >= slot.EndTime)
                {
                    throw new BadRequestException("Slot startime must smaller than endtime");
                }
                // check slot time is dupplicate or not
                if (!await ValidateSlotForCustomer(slot.StartTime, slot.EndTime, currentUserId))
                {
                    throw new ModelException("Slot", " Time of Slot is Dupplicated");
                }
                var baseSlot = await GetSlotByIdAsync(slot.BaseSlotId);
                if (baseSlot == null)
                {
                    throw new BadRequestException("The base slot is not found");
                }
                if (slot.StartTime < baseSlot.StartTime || slot.EndTime > baseSlot.EndTime)
                {
                    throw new BadRequestException($"Please specify the correct time range from the base slot. [Start : {baseSlot.StartTime}, End : {baseSlot.EndTime}]");
                }
                if (baseSlot.CreateById != training.PTId)
                {
                    throw new BadRequestException("One of the base slot does not belong to this PT");
                }
                var newSlot = new Slot()
                {
                    StartTime = DateTime.SpecifyKind(slot.StartTime, DateTimeKind.Utc),
                    EndTime = DateTime.SpecifyKind(slot.EndTime, DateTimeKind.Utc),
                    CreateById = user.FireBaseId,
                    TrainingId = trainingId,
                    Type = SlotType.Free,
                    Status = SlotStatus.Pending,
                };
                slots.Add(newSlot);
            }

            var resultSLot = await _slotRepository.AddRangeAsync(slots);
            if (resultSLot == null)
            {
                throw new ModelException("Slot", "error when adding slot");
            }
            return resultSLot.Adapt<List<GetSlotDto>>();
        }

        private bool HasOverlappingSlots(List<Slot> slots)
        {
            // Iterate through each slot in the list
            for (int i = 0; i < slots.Count; i++)
            {
                for (int j = i + 1; j < slots.Count; j++)
                {
                    // Check if the current slot (i) overlaps with any other slot (j)
                    if (IsOverlapping(slots[i], slots[j]))
                    {
                        return true;  // Overlap found
                    }
                }
            }

            return false;  // No overlap found
        }
        // Helper function to check if two slots overlap
        private bool IsOverlapping(Slot slot1, Slot slot2)
        {
            return slot1.StartTime < slot2.EndTime && slot1.EndTime > slot2.StartTime;
        }
        public async Task<GetSlotDetailDtos> GetSlotByIdAsync(Guid slotId)
        {
            var slot = await _slotRepository.GetSlotByIdAsync(slotId);
            if (slot is null)
            {
                throw new DataNotFoundException("Slot is not exist");
            }

            var slotDetailDtos = slot.Adapt<GetSlotDetailDtos>();
            return slotDetailDtos;

        }

        private async Task<bool> IsSlotTimeDupplicatedForPT(DateTime startTime, DateTime endTime, string userId, Guid? skip = null)
        {
            var userSlot = await _slotRepository.FindWithNoTrackingAsync(s => s.CreateById == userId);
            foreach (var slot in userSlot)
            {
                if (skip != null && slot.Id == skip) continue;
                if (startTime < slot.EndTime && endTime > slot.StartTime)
                {
                    return true; // There is a time overlap
                }
            }
            return false;
        }



        public async Task<bool> ValidateSlotForCustomer(DateTime start, DateTime end, string customerId, Guid? skip = null)
        {
            //var slot = await _slotRepository.FindOneAsync(s => s.Id == slotId);
            //if (slot == null)
            //{
            //    throw new DataNotFoundException("Slot not found");
            //}

            var listOfSlotOfCurrentUser = await _slotRepository.GetSlotsOfTrainee(customerId);

            foreach (var customerSlot in listOfSlotOfCurrentUser)
            {
                if (skip != null && customerSlot.Id == skip) continue;
                if (start.Date == end.Date)
                {
                    if (customerSlot.StartTime.Date == start.Date)
                    {
                        if (start.TimeOfDay < customerSlot.EndTime.TimeOfDay && end.TimeOfDay > customerSlot.StartTime.TimeOfDay)
                        {
                            throw new BadRequestException($"Có sự trùng lặp với slot có sẵn của bạn [Bắt đầu : {customerSlot.StartTime}; Kết thúc : {customerSlot.EndTime}], làm ơn kiểm tra lại");
                        }
                        continue;
                    }
                }
            }
            return true;
        }

        public async Task UpdateSlotTime(UpdateSlotTimeDto updateSlotTimeDto, string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            var existedSlot = await GetSlotByIdAsync(updateSlotTimeDto.SlotId);
            var newStartTime = updateSlotTimeDto.StartTime ?? existedSlot.StartTime;
            var newEndTime = updateSlotTimeDto.EndTime ?? existedSlot.EndTime;
            if (newStartTime >= newEndTime)
            {
                throw new BadRequestException("Slot's endtime must be larger then slot's start time");
            }
            if (newEndTime.Date != newStartTime.Date)
            {
                throw new BadRequestException("Slot's endtime must be in the same date as slot's start time");
            }
            if (user.Role == Role.Trainee)
            {
                if (existedSlot.Training == null || (existedSlot.Training.TraineeId != user.FireBaseId))
                {
                    throw new ForbiddenException("You don't have permission to do this function");
                }
                if (existedSlot.Status != SlotStatus.Pending)
                {
                    throw new BadRequestException("The slot must be in Pending status");
                }
                if (!await ValidateSlotForCustomer(newStartTime, newEndTime, userId, existedSlot.Id))
                {
                    throw new BadRequestException("Schedule conflict happened");
                }
            }
            if (user.Role == Role.PT)
            {
                if (existedSlot.CreateById != user.FireBaseId)
                {
                    throw new ForbiddenException("You don't have permission to do this function");
                }
                if (existedSlot.Status != SlotStatus.NotStarted && existedSlot.Status != SlotStatus.Unbooked)
                {
                    throw new BadRequestException("The slot must be in Unbooked or NotStarted status");
                }
                if (await IsSlotTimeDupplicatedForPT(newStartTime, newEndTime, userId, existedSlot.Id))
                {
                    throw new BadRequestException("Schedule conflict happened");
                }
            }
            var simpleSlot = await _slotRepository.FindOneWithNoTrackingAsync(s => s.Id == updateSlotTimeDto.SlotId);
            simpleSlot!.StartTime = DateTime.SpecifyKind(newStartTime, DateTimeKind.Utc);
            simpleSlot.EndTime = DateTime.SpecifyKind(newEndTime, DateTimeKind.Utc);
            await _slotRepository.UpdateAsync(simpleSlot);
        }

        public async Task UpdateSlotRating(string userId, UpdateSlotRatingDto updateSlotRatingDto)
        {
            var slot = await _slotRepository.FindOneWithNoTrackingAsync(s => s.Id == updateSlotRatingDto.SlotId);
            if (slot is null)
            {
                throw new DataNotFoundException("Slot is not found");
            }
            //Get by Id included the training here
            if (slot.Training == null)
            {
                throw new BadRequestException("You shall not update rating of this slot since it doesn't booked yet!");
            }
            if (slot.Training.TraineeId != userId)
            {
                throw new ForbiddenException("You don't have permission to do this function!");
            }
            if (slot.Status != Shared.Enum.SlotStatus.Finished)
            {
                throw new BadRequestException("You can only update this slot when it is finished!");
            }
            slot.Rating = updateSlotRatingDto.Rating;
            slot.Feedback = updateSlotRatingDto.Feedback;
            await _slotRepository.UpdateAsync(slot.Adapt<Slot>());
        }

        public async Task DeleteSlotAsync(Guid slotId, string currentUserFirebaseId)
        {
            var slot = await _slotRepository.FindOneWithNoTrackingAsync(s => s.Id == slotId);
            if (slot is null)
            {
                throw new DataNotFoundException("Slot is not found");
            }

            if (slot.CreateById != currentUserFirebaseId)
            {
                throw new ForbiddenException("You don't have permission to do this function!");
            }

            var listOfStatusToDelete = new List<SlotStatus>() { SlotStatus.Unbooked, SlotStatus.Pending, SlotStatus.NotStarted };
            if (!listOfStatusToDelete.Contains(slot.Status))
            {
                throw new BadRequestException($"Slot must be one of these Status{listOfStatusToDelete.ToList()} ");
            }
            await _slotRepository.DeleteAsync(slotId);
        }

        public async Task ApproveTrainingSlots(ApproveTrainingDto approveTrainingDto, string currentUserId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(currentUserId);
            var training = await _trainingService.GetDetailById(approveTrainingDto.TrainingId);
            if (training.PTId != currentUserId)
            {
                throw new ForbiddenException("You don't have permission to do this");
            }
            if (training.Status != TrainingStatus.Pending && training.Status != TrainingStatus.Rejected)
            {
                throw new BadRequestException("Training must be in pending or rejected status");
            }
            var freeSlots = await _slotRepository.FindWithNoTrackingAsync(s => s.Status == SlotStatus.Unbooked && s.CreateById == currentUserId);
            var updatingSlots = new List<Slot>();
            var deletingFreeSlots = new List<Slot>();
            var addingFreeSlots = new List<Slot>();
            foreach (var slot in training.Slots)
            {
                bool isAnySlotOutside = true;
                foreach (var freeSlot in freeSlots)
                {
                    if (slot.StartTime >= freeSlot.StartTime && slot.EndTime <= freeSlot.EndTime)
                    {
                        //This free slot will be divide into smaller slots
                        var freeSlotUpperRemain = new Slot
                        {
                            Id = Guid.NewGuid(),
                            EndTime = DateTime.SpecifyKind(slot.StartTime.AddMinutes(-(approveTrainingDto.MinuteDistance ?? 5)), DateTimeKind.Utc),
                            StartTime = freeSlot.StartTime,
                            Status = freeSlot.Status,
                            Type = freeSlot.Type,
                            CreateById = freeSlot.CreateById
                        };
                        var freeSlotLowerRemain = new Slot
                        {
                            Id = Guid.NewGuid(),
                            EndTime = freeSlot.EndTime,
                            StartTime = DateTime.SpecifyKind(slot.EndTime.AddMinutes(approveTrainingDto.MinuteDistance ?? 5), DateTimeKind.Utc),
                            Status = freeSlot.Status,
                            Type = freeSlot.Type,
                            CreateById = freeSlot.CreateById
                        };

                        if ((freeSlotUpperRemain.EndTime - freeSlotUpperRemain.StartTime).TotalMinutes >= 15)
                        {
                            addingFreeSlots.Add(freeSlotUpperRemain);
                        }
                        if ((freeSlotLowerRemain.EndTime - freeSlotLowerRemain.StartTime).TotalMinutes >= 15)
                        {
                            addingFreeSlots.Add(freeSlotLowerRemain);
                        }

                        deletingFreeSlots.Add(freeSlot);
                        //This slot has valid time frame
                        isAnySlotOutside = false;
                        break;
                    }
                }
                if (isAnySlotOutside)
                {
                    throw new BadRequestException("Some of the slot are not in your current free time");
                }
                var simpleSlot = await _slotRepository.FindOneWithNoTrackingAsync(s => s.Id == slot.Id);
                simpleSlot!.Status = SlotStatus.NotStarted;
                updatingSlots.Add(simpleSlot);
            }
            //Update the main slots
            await _slotRepository.UpdateRangeAsync(updatingSlots);
            //Add the new divided slots
            await _slotRepository.AddRangeAsync(addingFreeSlots);
            //Delete the old base slots
            await _slotRepository.DeleteRangeAsync(deletingFreeSlots);
            //Update the training
            await _trainingService.UpdateTrainingStatus(approveTrainingDto.TrainingId, TrainingStatus.NotStarted, currentUserId);
        }

        public async Task CancelTrainingSlots(Guid trainingId, string userId)
        {
            var training = await _trainingService.GetDetailById(trainingId);
            if (training.Status != TrainingStatus.Matched)
            {
                throw new BadRequestException("This training must be in Matched status to be modified");
            }
            foreach (var slot in training.Slots)
            {
                await _slotRepository.DeleteAsync(slot.Id);
            }
            if (training.Status == TrainingStatus.Pending)
            {
                await _trainingService.UpdateTrainingStatus(trainingId, TrainingStatus.Matched, userId);
            }
            else
            {
                await _trainingService.DeleteTraining(trainingId, userId);
            }
        }

        public async Task DeleteAllUnbookedSlotInARange(DateOnly start, DateOnly end, string userId)
        {
            var slots = await _slotRepository.Where(s => s.StartTime >= start.ToDateTime(TimeOnly.MinValue)
                && s.EndTime <= end.ToDateTime(TimeOnly.MaxValue)
                && s.CreateById == userId
                && s.Status == SlotStatus.Unbooked).ToListAsync();

            await _slotRepository.DeleteRangeAsync(slots);
        }
    }
}
