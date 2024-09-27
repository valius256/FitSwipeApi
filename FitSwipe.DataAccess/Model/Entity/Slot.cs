
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Slot : BaseEntity //Các slot của 1 chương trình huấn luyện (Training) - hoặc là các slot rảnh của tutor
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid? TrainingId { get; set; }
        public string CreateById { get; set; }
        public SlotType? Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
        public SlotStatus? Status { get; set; } // Trạng thái bắt đầu hay kết thúc của 1 slot
        public PaymentStatus? PaymentStatus { get; set; }
        public double? Rating { get; set; }
        public string? Feedback { get; set; }
        public virtual Training? Training { get; set; } = default!;
        public virtual User CreateBy { get; set; } = default!;

        public virtual ICollection<TransactionSlot> TransactionSlots { get; set; } = new List<TransactionSlot>();
        public virtual ICollection<SlotVideos> Videos { get; set; } = new List<SlotVideos>();
    }
}
