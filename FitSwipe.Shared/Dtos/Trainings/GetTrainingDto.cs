﻿
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Trainings
{
    public class GetTrainingDto
    {
        public Guid Id { get; set; }
        public string TraineeId { get; set; } = string.Empty;
        public string PTId { get; set; } = string.Empty;
        public TrainingStatus Status { get; set; }
        public int? PricePerSlot { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public string? Feedback { get; set; }
        public double? Rating { get; set; }
    }
}
