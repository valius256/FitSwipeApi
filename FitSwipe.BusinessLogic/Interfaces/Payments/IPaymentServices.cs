using FitSwipe.Shared.Model.Payment;
using FitSwipe.Shared.Model.Slot;
using Microsoft.AspNetCore.Http;

namespace FitSwipe.BusinessLogic.Interfaces.Payments
{
    public interface IPaymentServices
    {
        Task<string> CreatePaymentForSlotAsync(PaySlotDtos model, HttpContext context, GetSlotDetailDtos slot, string CurrentUserFirebaseId);
        Task<PaymentSlotResponseModel> PaymentExecuteAsync(IQueryCollection collections);
    }
}
