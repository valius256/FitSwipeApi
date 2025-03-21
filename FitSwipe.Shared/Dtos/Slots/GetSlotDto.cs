﻿
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class GetSlotDto
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid? TrainingId { get; set; }
        public string CreateById { get; set; } = string.Empty;
        public SlotType Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
        public SlotStatus Status { get; set; } // Trạng thái bắt đầu hay kết thúc của 1 slot
        public PaymentStatus PaymentStatus { get; set; }
        public string? Location { get; set; }
        public double? Rating { get; set; }
        public string? Feedback { get; set; }
        public int? SlotNumber { get; set; }
        public int TotalVideo { get; set; } = 0;
    }
}
