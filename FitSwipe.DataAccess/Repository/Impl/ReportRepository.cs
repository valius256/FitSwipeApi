
using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Reports;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class ReportRepository : GenericRepository<Report>, IReportRepository
    {
        private readonly FitSwipeDbContext _context;
        public ReportRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Report?> GetReportById(Guid id)
        {
            return await _context.Reports
                .Include(r => r.Reporter)
                .Include(r => r.Target)
                .Include(r => r.ReportImages)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<PagedResult<Report>> GetReportPagedAsync(PagingModel<QueryReportDto> request)
        {
            var query = _context.Reports.AsQueryable();

            if (request.Filter != null)
            {
                if (request.Filter.Reason != null)
                {
                    query = query.Where(r => r.Reason.Contains(request.Filter.Reason));
                }
                if (request.Filter.CreatedFrom.HasValue)
                {
                    query = query.Where(r => r.CreatedDate >= request.Filter.CreatedFrom);
                }
                if (request.Filter.CreatedTo.HasValue)
                {
                    query = query.Where(r => r.CreatedDate <= request.Filter.CreatedTo);
                }
                if (request.Filter.UpdatedFrom.HasValue)
                {
                    query = query.Where(r => r.UpdatedDate >= request.Filter.UpdatedFrom);
                }
                if (request.Filter.UpdatedTo.HasValue)
                {
                    query = query.Where(r => r.UpdatedDate <= request.Filter.UpdatedTo);
                }
                if (request.Filter.Status.Count > 0)
                {
                    query = query.Where(r => request.Filter.Status.Contains(r.Status));
                }
                
            }
            int limit = request.Limit > 0 ? request.Limit : 10;
            int page = request.Page > 0 ? request.Page : 1;

            return await query.OrderBy(r => r.CreatedDate).ToNewPagingAsync(page, limit);
        }
    }
}
