
using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.RequestWithdraw
{
    public class CreateRequestWithdrawDto
    {
        public string? Reason { get; set; } = string.Empty;
        [Required] public required int Amount { get; set; }
        [Required] public required string AccountNumber { get; set; } = string.Empty;
        [Required] public required string ReceiverName { get; set; } = string.Empty;
        [Required] public required string BankName { get; set; } = string.Empty;
    }
}
