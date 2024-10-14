using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Transactions
{
    public class CreateTransactionDtos
    {
        [Required]
        public required string TranscationCode { get; set; }
        [Required]
        public required string UserFireBaseId { get; set; }
        public int Amount { get; set; }
        public TransactionMethod Method { get; set; }
        public string? Description { get; set; }
        // New property to hold Slot IDs
        public List<Guid> SlotIds { get; set; } = new List<Guid>();
    }
}
