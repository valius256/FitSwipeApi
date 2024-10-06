
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class QuerySlotDto
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Guid? TrainingId { get; set; }
        public string? CreateById { get; set; }
        public string? TraineeId { get; set; }
        public SlotType? Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
        public List<SlotStatus> Status { get; set; } = new List<SlotStatus>();
        public List<PaymentStatus> PaymentStatus { get; set; } = new List<PaymentStatus>();
        public double? RatingFrom { get; set; }
        public double? RatingTo { get; set; }
        public bool? IsFeedbacked { get; set; }
    }
}
