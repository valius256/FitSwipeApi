
using FitSwipe.Shared.Dtos.FeedbackImages;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class GetTrainingDetailDto
    {
        public Guid Id { get; set; }
        public string TraineeId { get; set; } = string.Empty;
        public string PTId { get; set; } = string.Empty;
        public TrainingStatus Status { get; set; }
        public string? Feedback { get; set; }
        public double? Rating { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public GetUserDto Trainee { get; set; } = default!;
        public GetUserDto PT { get; set; } = default!;
        public ICollection<GetSlotDto> Slots { get; set; } = new List<GetSlotDto>();
        public ICollection<GetFeedbackImageDto> FeedbackImages { get; set; } = new List<GetFeedbackImageDto>();
    }
}
