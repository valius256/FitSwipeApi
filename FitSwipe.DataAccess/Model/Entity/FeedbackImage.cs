
namespace FitSwipe.DataAccess.Model.Entity
{
    public class FeedbackImage : BaseEntity
    {
        public string MediaUrl { get; set; }
        public Guid TrainingId { get; set; }
        public virtual Training Training { get; set; } = default!;
    }
}
