using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Payment
{
    public class PaymentSlotResponseModel
    {
        [Required]
        public string OrderDescription { get; set; }
        [Required]
        public int TransactionId { get; set; }
        [Required]
        public string TransactionCode { get; set; }
        [Required]
        public decimal Money { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public bool Success { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public string VnPayResponseCode { get; set; }
        [Required]
        public List<Guid> SlotIds { get; set; }
        [Required]
        public string UserFireBaseId { get; set; }
        [Required]
        public bool IsRechargePayment { get; set; }
        [Required]
        public PaymentStatus PaymentStatus { get; set; }
        [Required]
        public string? RedirectResult { get; set; }
        [Required]
        public OrderType OrderType { get; set; }
    }
}
