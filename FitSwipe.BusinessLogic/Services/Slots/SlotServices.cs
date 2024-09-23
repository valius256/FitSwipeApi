using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Slot;
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

        public async Task<GetSlotDetailDtos> CreateSlotAsync(CreateSlotDtos model, string currentUserId)
        {
            var currPTEntity = await _userServices.GetUserByIdRequiredAsync(currentUserId);
            // check slot time is dupplicate or not 

            if (await IsSlotTimeDupplicatedForPT(model.StartTime, model.EndTime, currentUserId))
            {
                throw new ModelException("Slot", "Slot time is dupplicated");
            }
            if (currPTEntity.FireBaseId is null)
            {
                throw new ModelException("PT", "PT not found");
            }

            var newSlot = model.Adapt<Slot>();
            newSlot.CreateById = currPTEntity.FireBaseId;
            await _slotRepository.AddAsync(newSlot);
            var returnSlot = newSlot.Adapt<GetSlotDetailDtos>();
            return returnSlot;
        }

        public async Task<GetSlotDetailDtos>? GetSlotByIdAsync(Guid slotId)
        {
            var slot = await _slotRepository.FindOneAsync(s => s.Id == slotId);
            if (slot is null)
            {
                return null;
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
                if (slot.StartTime <= customerSlot.EndTime && slot.EndTime >= customerSlot.StartTime)
                {
                    throw new BadRequestException($"Có sự trùng lặp với slot có sẵn của bạn [Bắt đầu : {customerSlot.StartTime}; Kết thúc : {customerSlot.EndTime}], làm ơn kiểm tra lại");
                }


            }
            return true;


        }
    }
}
