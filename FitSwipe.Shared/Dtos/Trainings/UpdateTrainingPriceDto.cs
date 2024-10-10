
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class UpdateTrainingPriceDto
    {
        [Required]
        public required Guid TrainingId { get; set; }
        [Required]
        public required int TrainingPrice { get; set; }
    }
}
