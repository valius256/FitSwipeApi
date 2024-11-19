

using FitSwipe.BusinessLogic.Interfaces.Reports;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Reports;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Reports
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IUserServices _userServices;
        private readonly IReportImageService _reportImageService;
        public ReportService(IReportRepository reportRepository, IUserServices userServices, IReportImageService reportImageService)
        {
            _reportRepository = reportRepository;
            _userServices = userServices;
            _reportImageService = reportImageService;
        }

        public async Task<GetReportDto> CreateReport(CreateReportDto createReportDto, string reporterId)
        {
            await _userServices.GetUserByIdRequiredAsync(reporterId);
            await _userServices.GetUserByIdRequiredAsync(createReportDto.TargetId);

            var report = createReportDto.Adapt<Report>();
            report.CreatedDate = DateTime.UtcNow.AddHours(7);
            report.Status = RequestStatus.Pending;
            report.ReporterId = reporterId;

            var createdReport = await _reportRepository.AddAsync(report);
            await _reportImageService.CreateReportImages(createReportDto.ImageUrls, createdReport.Id);
            return createdReport.Adapt<GetReportDto>();
        }

        public async Task<PagedResult<GetReportDto>> GetPagedReport(PagingModel<QueryReportDto> request)
        {
            return (await _reportRepository.GetReportPagedAsync(request)).Adapt<PagedResult<GetReportDto>>();
        }

        public async Task<GetReportDetailDto> GetReportDetail(Guid guid)
        {
            var report = await _reportRepository.GetReportById(guid);
            if (report == null)
            {
                throw new DataNotFoundException("Report not found");
            }
            return report.Adapt<GetReportDetailDto>();
        }

        public async Task UpdateReport(UpdateReportDto updateReportDto)
        {
            var report = await _reportRepository.GetByIdAsync(updateReportDto.Id);
            if (report == null)
            {
                throw new DataNotFoundException("Report not found");   
            }
            if (updateReportDto.Status == RequestStatus.Pending)
            {
                throw new BadRequestException("Can't not update report to status Pending");
            }
            report.Status = updateReportDto.Status;
            report.UpdatedDate = DateTime.UtcNow.AddHours(7);
            await _reportRepository.UpdateAsync(report);
        }
    }
}
