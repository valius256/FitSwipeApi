using FitSwipe.Shared.Dtos.Payment;
using FitSwipe.Shared.Enum;
using Microsoft.AspNetCore.Http;

namespace FitSwipe.BusinessLogic.Interfaces.Payments
{
    public interface IPaymentServices
    {
        Task<string> CreatePaymentForSlotAsync(PaySlotDtos model, HttpContext context, string CurrentUserFirebaseId);
        Task<PaymentSlotResponseModel> PaymentExecuteAsync(IQueryCollection collections);
        Task<string> CreatePaymentForSlotByPayOsAsync(PaySlotDtos model, string CurrentUserFirebaseId);
        Task HandleSlotsPayment(List<Guid> slotIds);
        Task<string> HandlePayOsCallBackAsync(string code, string id, bool cancel, string status, int orderCode);
        Task HandleSlotsPaymentWithBalance(List<Guid> slotIds, string userId);
        Task<string> CreatePaymentRecharge(string userId, int amount);
        Task<string> CreatePaymentSubscription(string userId, int level);
        Task HandleSubscriptionPaymentWithBalance(string userId, int level);
        Task CronForUAutoPurchaseByUserBalance();
        Task CronChangeSubscriptionStatusWhenOverdue();
    }
}
