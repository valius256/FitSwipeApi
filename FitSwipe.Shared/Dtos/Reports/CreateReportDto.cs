

using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Reports
{
    public class CreateReportDto
    {
        [Required]
        public required string TargetId { get; set; }
        [Required]
        public required string Reason { get; set; }

        public List<string> ImageUrls { get; set; } = [];
    }
}
