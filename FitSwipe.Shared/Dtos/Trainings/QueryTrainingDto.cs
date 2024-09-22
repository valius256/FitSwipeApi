
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class QueryTrainingDto
    {
        public string? TraineeId { get; set; }
        public string? PTId { get; set; }
        public List<TrainingStatus> TrainingStatuses { get; set; } = new List<TrainingStatus>();
    }
}
