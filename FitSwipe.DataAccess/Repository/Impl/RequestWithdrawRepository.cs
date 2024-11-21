
using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.RequestWithdraw;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class RequestWithdrawRepository : GenericRepository<RequestWithdraw>, IRequestWithdrawRepository
    {
        private readonly FitSwipeDbContext _context;
        public RequestWithdrawRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedResult<RequestWithdraw>> GetRequestWithdrawPagedAsync(PagingModel<QueryRequestWithdrawDto> pagingModel)
        {
            var query = _context.RequestWithdraws.AsQueryable();

            if (pagingModel.Filter != null)
            {
                if (pagingModel.Filter.UserId != null)
                {
                    query = query.Where(rw => rw.UserId == pagingModel.Filter.UserId);
                }
                if (pagingModel.Filter.IsUpdated.HasValue)
                {
                    query = query.Where(rw => rw.Status != Shared.Enum.RequestStatus.Pending);
                }
            }

            var limit = pagingModel.Limit > 0 ? pagingModel.Limit : 10;
            var page = pagingModel.Page > 0 ? pagingModel.Page : 1;
            return await query.OrderByDescending(r => r.CreatedDate).ToNewPagingAsync(page, limit);
        }
    }
}
