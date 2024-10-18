
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.RequestWithdraw;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IRequestWithdrawRepository : IGenericRepository<RequestWithdraw>
    {
        Task<PagedResult<RequestWithdraw>> GetRequestWithdrawPagedAsync(PagingModel<QueryRequestWithdrawDto> pagingModel);
    }
}
