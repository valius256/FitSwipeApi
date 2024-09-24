using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Model.Slot
{
    public class GetSlotDetailDtos
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? TrainingId { get; set; }
        public string CreateById { get; set; }
        public SlotType Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
        public SlotStatus Status { get; set; } // Trạng thái bắt đầu hay kết thúc của 1 slot
        public PaymentStatus PaymentStatus { get; set; }
        public double? Rating { get; set; }
        public string? Feedback { get; set; }

    }
}
