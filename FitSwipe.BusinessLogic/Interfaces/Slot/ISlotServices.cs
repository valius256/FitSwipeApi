using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.BusinessLogic.Interfaces.Slot
{
    public interface ISlotServices
    {
        Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
        Task<GetSlotDetailDtos> GetSlotByIdAsync(Guid slotId);
        Task<bool> ValidateSlotForCustomer(Guid slotId, string customerId);
        Task<List<GetSlotDto>> CreateFreeSlotForPTAsync(List<CreateSlotDtos> model, string currentUserId);
        Task UpdateSlotRating(string userId, UpdateSlotRatingDto updateSlotRatingDto);
        Task DeleteSlotAsync(Guid slotId, string currentUserFirebaseId);
    }
}
