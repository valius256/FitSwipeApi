

using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class UpdateSlotRatingDto
    {
        [Required]
        public required Guid SlotId { get; set; }
        [Required]
        [Range(1,5)]
        public required int Rating { get; set; }
        public string? Feedback { get; set; }
    }
}
