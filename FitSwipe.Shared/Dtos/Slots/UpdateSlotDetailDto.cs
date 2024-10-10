using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class UpdateSlotDetailDto
    {
        [Required]
        public Guid SlotId { get; set; }
        [Required]
        public List<CreateSlotVideoDtos> SlotVideos { get; set; } = [];
        public string? Location { get; set; }
    }
}
