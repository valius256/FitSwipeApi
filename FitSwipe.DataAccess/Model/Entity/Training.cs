
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Training : BaseEntity //Cái này giống như class. Hiểu là chương trình huấn luyện 1-1 giữa trainee và PT
    {
        public string TraineeId { get; set; }
        public string PTId { get; set; }
        public TrainingStatus Status { get; set; }
        public string? Feedback { get; set; }
        public double? Rating { get; set; }
        public virtual User Trainee { get; set; } = default!;
        public virtual User PT { get; set; } = default!;
        public virtual ICollection<Slot> Slots { get; set; } = new List<Slot>();
        public virtual ICollection<FeedbackImage> FeedbackImages { get; set; } = new List<FeedbackImage>();
    }
}
