﻿using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface ISlotRepository : IGenericRepository<Slot>
    {
        Task<PagedResult<Slot>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
        Task<Slot?> GetSlotByIdAsync(Guid slotId);
        Task<List<Slot>> GetSlotsOfTrainee(string traineeId);
        Task<List<Slot>> GetSlotsOfPT(string PTId);
        Task<int> CountSlotVideoAsync(Guid slotId);
        Task<List<Slot>> GetAllDebtSlotsOfTrainee(string traineeId);
        Task<List<Slot>> GetUpcomingSlotsOfPT(string traineeId, int limit);
    }
}
