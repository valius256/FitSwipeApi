﻿
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Reports
{
    public class GetReportDto
    {
        public Guid Id { get; set; }
        public string ReporterId { get; set; } = string.Empty;
        public string TargetId { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(7);
        public DateTime? UpdatedDate { get; set; }
        public RequestStatus Status { get; set; }
    }
}
