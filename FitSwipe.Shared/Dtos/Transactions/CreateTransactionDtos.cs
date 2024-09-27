using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Transactions
{
    public class CreateTransactionDtos
    {
        public string TranscationCode { get; set; }
        public string UserFireBaseId { get; set; }
        public int Amount { get; set; }
        public TransactionMethod Method { get; set; }

        // New property to hold Slot IDs
        public List<Guid> SlotIds { get; set; } = new List<Guid>();
    }
}
