using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Model.Slot;

namespace FitSwipe.BusinessLogic.Interfaces.Slot
{
    public interface ISlotServices
    {
        Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
        Task<GetSlotDetailDtos>? GetSlotByIdAsync(Guid slotId);
        Task<bool> ValidateSlotForCustomer(Guid slotId, string customerId);
        Task<GetSlotDetailDtos> CreateSlotAsync(CreateSlotDtos model, string currentUserId);
        Task UpdateSlotRating(string userId, UpdateSlotRatingDto updateSlotRatingDto);
    }
}
