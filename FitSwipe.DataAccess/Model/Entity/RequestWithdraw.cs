
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class RequestWithdraw : BaseEntity
    {
        public string UserId { get; set; }
        public string? HandlerId { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string? OperatorMessage { get; set; }
        public RequestStatus Status { get; set; }
        public string? TransactionCode { get; set; }
        public virtual User User { get; set; } = default!;
        public virtual User? Handler { get; set; }
    }
}
