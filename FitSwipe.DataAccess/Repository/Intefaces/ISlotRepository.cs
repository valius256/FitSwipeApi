using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface ISlotRepository : IGenericRepository<Slot>
    {
        Task<PagedResult<Slot>> GetSlots(PagingModel<QuerySlotDto> pagingModel);
    }
}
