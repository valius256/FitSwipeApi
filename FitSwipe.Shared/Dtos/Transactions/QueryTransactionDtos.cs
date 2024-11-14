using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Transactions
{
    public class QueryTransactionDtos
    {
        public string? TranscationCode { get; set; }
        public List<TransactionMethod>? Method { get; set; }
        public List<TransactionStatus>? Status { get; set; }
        public int? MaxAmount { get; set; }
        public int? MinAmount { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
