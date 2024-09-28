using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Slots
{
    public class SlotServices : ISlotServices
    {
        private readonly ISlotRepository _slotRepository;
        private readonly IUserServices _userServices;
        public SlotServices(ISlotRepository slotRepository, IUserServices userServices)
        {
            _userServices = userServices;
            _slotRepository = slotRepository;
        }

        public async Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel)
        {
            return (await _slotRepository.GetSlots(pagingModel)).Adapt<PagedResult<GetSlotDto>>();
        }

        public async Task<GetSlotDetailDtos> CreateSlotAsync(CreateSlotDtos model, string currentUserId)
        {
            var currPTEntity = await _userServices.GetUserByIdRequiredAsync(currentUserId);
            // check user create is PT or not
            if (currPTEntity.Role != Shared.Enum.Role.PT)
            {
                throw new ModelException("PT", "You are not PT");
            }

            // check slot time is dupplicate or not
            if (await IsSlotTimeDupplicatedForPT(model.StartTime, model.EndTime, currentUserId))
            {
                throw new ModelException("Slot", " Time of Slot is Dupplicated");
            }
            if (currPTEntity.FireBaseId is null)
            {
                throw new ModelException("PT", "PT Not found");
            }

            var newSlot = model.Adapt<Slot>();
            newSlot.CreateById = currPTEntity.FireBaseId;
            var resultSLot = await _slotRepository.AddAsync(newSlot);
            if (resultSLot == null)
            {
                throw new ModelException("Slot", "error when adding slot");
            }
            return resultSLot.Adapt<GetSlotDetailDtos>();
        }

        public async Task<GetSlotDetailDtos> GetSlotByIdAsync(Guid slotId)
        {
            var slot = await _slotRepository.GetSlotDetailDtos(slotId);
            if (slot is null)
            {
                throw new BadRequestException("Slot is not exist");
            }

            var slotDetailDtos = slot.Adapt<GetSlotDetailDtos>();
            return slotDetailDtos;

        }

        public async Task<bool> IsSlotTimeDupplicatedForPT(DateTime startTime, DateTime endTime, string userId)
        {
            var userSlot = await _slotRepository.FindAsync(s => s.CreateById == userId);
            foreach (var slot in userSlot)
            {
                if (startTime < slot.EndTime && endTime > slot.StartTime)
                {
                    return true; // There is a time overlap
                }
            }
            return false;
        }



        public async Task<bool> ValidateSlotForCustomer(Guid slotId, string customerId)
        {
            var slot = await _slotRepository.FindOneAsync(s => s.Id == slotId);
            if (slot == null)
            {
                throw new DataNotFoundException("Slot not found");
            }

            var listOfSlotOfCurrentUser = await _slotRepository.FindAsync(s => s.Training.TraineeId == customerId);

            foreach (var customerSlot in listOfSlotOfCurrentUser)
            {
                if (customerSlot.Id == slotId) continue;
                if (slot.StartTime.Date == slot.EndTime.Date)
                {
                    if (customerSlot.StartTime.Date == slot.StartTime.Date)
                    {
                        if (slot.StartTime.TimeOfDay < customerSlot.EndTime.TimeOfDay && slot.EndTime.TimeOfDay > customerSlot.StartTime.TimeOfDay)
                        {
                            throw new BadRequestException($"Có sự trùng lặp với slot có sẵn của bạn [Bắt đầu : {customerSlot.StartTime}; Kết thúc : {customerSlot.EndTime}], làm ơn kiểm tra lại");
                        }
                        continue;
                    }
                }
            }
            return true;


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
            if (!listOfStatusToDelete.Contains(slot.Status.Value))
            {
                throw new BadRequestException($"Slot must be one of these Status{listOfStatusToDelete.ToList()} ");
            }


            await _slotRepository.DeleteAsync(slotId);
        }
    }
}
