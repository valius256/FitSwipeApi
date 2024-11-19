

using FitSwipe.BusinessLogic.Interfaces.Reports;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.BusinessLogic.Services.Reports
{
    public class ReportImageService : IReportImageService
    {
        private readonly IReportImageRepository _reportImageRepository;

        public ReportImageService(IReportImageRepository reportImageRepository)
        {
            _reportImageRepository = reportImageRepository;
        }

        public async Task CreateReportImages(List<string> images, Guid reportId)
        {
            var reportImages = new List<ReportImage>();
            foreach (var image in images)
            {
                reportImages.Add(new ReportImage
                {
                    MediaUrl = image,
                    ReportId = reportId
                });
            }
            await _reportImageRepository.AddRangeAsync(reportImages);
        }
    }
}
