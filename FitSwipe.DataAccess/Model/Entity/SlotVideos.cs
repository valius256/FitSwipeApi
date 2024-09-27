namespace FitSwipe.DataAccess.Model.Entity
{
    public class SlotVideos : BaseEntity
    {
        public Guid SlotId { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Description { get; set; }
        public virtual Slot Slot { get; set; } = default!;
    }
}
