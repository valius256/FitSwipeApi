
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.RequestWithdraw
{
    public class GetRequestWithdrawDto
    {
        public Guid Id { get; set; }
        public required string UserId { get; set; }
        public string? HandlerId { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string OperatorMessage { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public RequestStatus Status { get; set; }
    }
}
