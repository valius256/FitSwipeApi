using FitSwipe.Shared.Model.Slot;

namespace FitSwipe.BusinessLogic.Interfaces.Slot
{
    public interface ISlotServices
    {
        Task<GetSlotDetailDtos>? GetSlotByIdAsync(Guid slotId);

        Task<bool> ValidateSlotForCustomer(Guid slotId, string customerId);
        Task<GetSlotDetailDtos> CreateSlotAsync(CreateSlotDtos model, string currentUserId);
    }
}
