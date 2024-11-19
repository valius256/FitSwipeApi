
namespace FitSwipe.Shared.Dtos.Reports
{
    public class GetReportImageDto
    {
        public string MediaUrl { get; set; } = string.Empty;
        public Guid ReportId { get; set; }
    }
}
