

using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Reports
{
    public class QueryReportDto
    {
        public string? Reason { get; set; }
        public DateTime? CreatedFrom { get; set; }
        public DateTime? CreatedTo { get; set; }
        public DateTime? UpdatedFrom { get; set; }
        public DateTime? UpdatedTo { get; set; }
        public List<RequestStatus> Status { get; set; } = [];
    }
}
