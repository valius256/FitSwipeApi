using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Payment
{
    public class PaymentSlotResponseModel
    {
        public string OrderDescription { get; set; }
        public int TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public decimal Money { get; set; }
        public string PaymentMethod { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public string VnPayResponseCode { get; set; }
        public List<Guid> SlotIds { get; set; }
        public string UserFireBaseId { get; set; }
        public bool IsRechargePayment { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string? RedirectResult { get; set; }
    }
}
