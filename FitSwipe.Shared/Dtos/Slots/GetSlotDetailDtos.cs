using FitSwipe.Shared.Dtos.Trainings;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class GetSlotDetailDtos
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? TrainingId { get; set; }
        public string CreateById { get; set; } = string.Empty;
        public SlotType Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
        public SlotStatus Status { get; set; } // Trạng thái bắt đầu hay kết thúc của 1 slot
        public PaymentStatus PaymentStatus { get; set; }
        public double? Rating { get; set; }
        public string? Feedback { get; set; }
        public string? Location { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public virtual GetTrainingDto? Training { get; set; } = default!;
        public virtual GetUserDto CreateBy { get; set; } = default!;

        //public virtual ICollection<GetTra> TransactionSlots { get; set; } = new List<TransactionSlot>();
        public virtual ICollection<GetSlotVideoDto> Videos { get; set; } = new List<GetSlotVideoDto>();

    }
}
