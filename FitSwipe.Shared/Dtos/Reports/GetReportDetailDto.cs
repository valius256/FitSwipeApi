

using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Reports
{
    public class GetReportDetailDto
    {
        public Guid Id { get; set; }
        public string ReporterId { get; set; } = string.Empty;
        public string TargetId { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(7);
        public DateTime? UpdatedDate { get; set; }
        public RequestStatus Status { get; set; }

        public GetUserDto Reporter { get; set; } = default!;
        public GetUserDto Target { get; set; } = default!;
        public ICollection<GetReportImageDto> ReportImages { get; set; } = new List<GetReportImageDto>();
    }
}
