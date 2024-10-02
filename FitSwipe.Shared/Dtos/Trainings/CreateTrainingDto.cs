
using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class CreateTrainingDto
    {
        [Required]
        public required string TrainneId { get; set; }
        public TrainingStatus Status { get; set; } = TrainingStatus.Matched;
    }
}
