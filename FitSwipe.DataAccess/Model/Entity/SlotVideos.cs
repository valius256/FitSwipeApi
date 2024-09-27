namespace FitSwipe.DataAccess.Model.Entity
{
    public class SlotVideos : BaseEntity
    {
        public Guid SlotId { get; set; }
        public string VideoUrl { get; set; }
        public string Url { get; set; }
        public virtual Slot Slot { get; set; } = default!;
    }
}
