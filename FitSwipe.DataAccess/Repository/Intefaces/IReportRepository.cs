

using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Reports;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IReportRepository : IGenericRepository<Report>
    {
        Task<PagedResult<Report>> GetReportPagedAsync(PagingModel<QueryReportDto> request);
        Task<Report?> GetReportById(Guid id);
    }
}
