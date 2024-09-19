
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Transaction : BaseEntity
    {
        public string TranscationCode { get; set; }
        public TransactionMethod Method { get; set; }
        public TransactionStatus Status { get; set; }
        public Guid UserId { get; set; } //Người dùng chịu trách nhiệm chính cho giao dịch này
        public int Amount { get; set; }

        public virtual User User { get; set; } = default!;
    }
}
