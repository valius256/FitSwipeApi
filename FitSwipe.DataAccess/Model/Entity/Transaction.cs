
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Transaction : BaseEntity
    {
        public string TranscationCode { get; set; }
        public TransactionMethod Method { get; set; }
        public TransactionStatus Status { get; set; }
        public TransactionType Type { get; set; }
        public string UserFireBaseId { get; set; } //Người dùng chịu trách nhiệm chính cho giao dịch này
        public int Amount { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; } = default!;

        public virtual ICollection<TransactionSlot> TransactionSlots { get; set; } = new List<TransactionSlot>();
    }
}
