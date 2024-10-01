using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.BusinessLogic.Interfaces.Slots
{
    public interface ISlotServices
    {
        Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
        Task<GetSlotDetailDtos> GetSlotByIdAsync(Guid slotId);
        Task<bool> ValidateSlotForCustomer(DateTime start, DateTime end, string customerId, Guid? skip = null);
        Task<List<GetSlotDto>> CreateFreeSlotForPTAsync(List<CreateSlotDtos> model, string currentUserId);
        Task<List<GetSlotDto>> CreateTrainingSlot(List<CreateTrainingSlotDto> request, Guid trainingId, string currentUserId);
        Task UpdateSlotRating(string userId, UpdateSlotRatingDto updateSlotRatingDto);
        Task UpdateSlotTime(UpdateSlotTimeDto updateSlotTimeDto, string userId);
        Task DeleteSlotAsync(Guid slotId, string currentUserFirebaseId);

        Task ApproveTrainingSlots(ApproveTrainingDto approveTrainingDto, string currentUserId);
    }
}
