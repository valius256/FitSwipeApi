
namespace FitSwipe.Shared.Dtos.Trainings
{
    public class GetTrainingOverviewDto
    {
        public DateTime? StartTime { get; set; } //Start time of the first slot
        public DateTime? EndTime { get; set; } //End time of the last slot
        public int TotalDuration { get; set; } //Total duration in hours of all slots
        public int TotalSlots { get; set; } //Total slot numbers
    }
}
