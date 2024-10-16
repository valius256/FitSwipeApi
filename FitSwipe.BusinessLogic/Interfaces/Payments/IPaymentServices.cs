using FitSwipe.Shared.Dtos.Payment;
using Microsoft.AspNetCore.Http;

namespace FitSwipe.BusinessLogic.Interfaces.Payments
{
    public interface IPaymentServices
    {
        Task<string> CreatePaymentForSlotAsync(PaySlotDtos model, HttpContext context, string CurrentUserFirebaseId);
        Task<PaymentSlotResponseModel> PaymentExecuteAsync(IQueryCollection collections);
        Task<string> CreatePaymentForSlotByPayOsAsync(PaySlotDtos model, string CurrentUserFirebaseId);
        Task HandleSlotsPayment(List<Guid> slotIds);

    }
}
