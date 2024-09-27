using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Transactions
{
    public class GetSimpleTransactionDtos
    {
        public string TranscationCode { get; set; }
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public TransactionMethod Method { get; set; }
        public TransactionStatus Status { get; set; }
        public string Description { get; set; }
        public List<Guid> TransactionSlot { get; set; } = new List<Guid>();
    }
}
