

using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Reports
{
    public class UpdateReportDto
    {
        [Required]
        public required Guid Id { get; set; }
        [Required]
        public required RequestStatus Status { get; set; }

    }
}
