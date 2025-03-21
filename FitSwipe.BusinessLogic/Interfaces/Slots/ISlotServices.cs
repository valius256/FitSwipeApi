﻿using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.BusinessLogic.Interfaces.Slots
{
    public interface ISlotServices
    {
        Task<PagedResult<GetSlotDto>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
        Task<GetSlotDetailDtos> GetSlotByIdAsync(Guid slotId);
        Task<List<GetSlotDetailDtos>> GetAllDebtSlotsOfTrainee(string traineeId);
        Task<bool> ValidateSlotForCustomer(DateTime start, DateTime end, string customerId, Guid? skip = null);
        Task<List<GetSlotDto>> CreateFreeSlotForPTAsync(List<CreateSlotDtos> model, string currentUserId);
        Task<List<GetSlotDto>> CreateTrainingSlot(List<CreateTrainingSlotDto> request, Guid trainingId, string currentUserId);
        Task UpdateSlotRating(string userId, UpdateSlotRatingDto updateSlotRatingDto);
        Task UpdateSlotTime(UpdateSlotTimeDto updateSlotTimeDto, string userId);
        Task DeleteSlotAsync(Guid slotId, string currentUserFirebaseId);

        Task ApproveTrainingSlots(ApproveTrainingDto approveTrainingDto, string currentUserId);
        Task CancelTrainingSlots(Guid trainingId, string userId);
        Task DeleteAllUnbookedSlotInARange(DateOnly start, DateOnly end, string userId);
        Task UpdateSlotDetail(UpdateSlotDetailDto updateSlotDetailDto, string userId);
        Task<int> CountSlotVideos(Guid id);
        Task UpdateRangePayment(List<Guid> slotIds);
        Task UpdateSlotsWhenTrainingFinished(string userId);
        Task<List<GetSlotDetailDtos>> GetAllSlotInCurrentDate();
        Task<List<GetSlotDetailDtos>> GetUpcomingSlotsOfPT(string ptId, int limit);
        Task CronJobUpdateSlotStatus();

    }
}
