
namespace FitSwipe.Shared.Dtos.Slots
{
    public class GetSlotVideoDto
    {
        public Guid SlotId { get; set; }
        public string VideoUrl { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
