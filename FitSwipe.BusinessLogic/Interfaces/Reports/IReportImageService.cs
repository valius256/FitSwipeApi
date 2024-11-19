

namespace FitSwipe.BusinessLogic.Interfaces.Reports
{
    public interface IReportImageService
    {
        Task CreateReportImages(List<string> images, Guid reportId);
    }
}
