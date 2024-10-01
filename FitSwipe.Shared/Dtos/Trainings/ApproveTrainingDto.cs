
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class ApproveTrainingDto
    {
        [Required]
        public required Guid TrainingId { get; set; }
        public int? MinuteDistance { get; set; }
    }
}
