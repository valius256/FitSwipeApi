

using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Reports;

namespace FitSwipe.BusinessLogic.Interfaces.Reports
{
    public interface IReportService
    {
        Task<PagedResult<GetReportDto>> GetPagedReport(PagingModel<QueryReportDto> request);
        Task<GetReportDetailDto> GetReportDetail(Guid guid);
        Task<GetReportDto> CreateReport(CreateReportDto createReportDto, string reporterId);
        Task UpdateReport(UpdateReportDto updateReportDto);
    }
}
