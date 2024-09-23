using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.DataAccess.Model;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Payment;
using FitSwipe.Shared.Model.Slot;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace FitSwipe.BusinessLogic.Services.Payments
{
    public class PaymentServices : IPaymentServices
    {
        private readonly IUserServices _userServices;
        private readonly ISlotServices _slotServices;
        private readonly VnPay _vnPay;
        public PaymentServices(IUserServices userServices, ISlotServices slotServices, IOptions<VnPay> vnPay)
        {
            _userServices = userServices;
            _slotServices = slotServices;
            _vnPay = vnPay.Value;
        }

        public async Task<string> CreatePaymentForSlotAsync(PaySlotDtos model, HttpContext context, GetSlotDetailDtos slot, string CurrentUserFirebaseId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(CurrentUserFirebaseId);

            if (user is null)
            {
                throw new Exception("User not found");
            }

            var slotDetailDtos = await _slotServices.GetSlotByIdAsync(model.SlotId);
            var isSlotValid = await _slotServices.ValidateSlotForCustomer(model.SlotId, user.FireBaseId);
            if (!isSlotValid)
            {
                throw new ModelException("Slot", "Slot không hợp lệ");
            }
            var ptOfSlot = await _userServices.GetProfileUserAsync(slotDetailDtos.CreateById.ToString());

            var tick = DateTime.Now.Ticks.ToString();
            if (ptOfSlot.PricePerHour == 0)
            {
                throw new ModelException("PT", "PT chưa đủ điều kiện dạy");
            }

            var slotCost = (slotDetailDtos.EndTime - slotDetailDtos.StartTime).TotalHours * ptOfSlot.PricePerHour;

            var paymentUrl = CreateVnPayRequest(model, context, new List<Guid> { slotDetailDtos.Id }, slotCost, model.OrderDescription, false, tick, model.ReturnUrl);
            return paymentUrl;

        }

        private string CreateVnPayRequest<T>(T model, HttpContext context, List<Guid>? slotId, double amount, string? description, bool? isRechargePayment, string tick, string? returnPage)
        {
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_vnPay.TimeZoneId);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var pay = new VnPayLibrary();

            var currUid = context.User.FindFirst(c => c.Type == "user_id")?.Value;
            string slotIdString = slotId != null ? string.Join(" ", slotId) : string.Empty;
            pay.AddRequestData("vnp_Version", _vnPay.Version);
            pay.AddRequestData("vnp_Command", _vnPay.Command);
            pay.AddRequestData("vnp_TmnCode", _vnPay.TmnCode);
            pay.AddRequestData("vnp_Amount", ((int)amount * 100).ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _vnPay.CurrCode);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _vnPay.Locale);
            pay.AddRequestData("vnp_OrderInfo", $"{isRechargePayment}|{description}|{currUid}|{returnPage}|{slotIdString}");
            pay.AddRequestData("vnp_OrderType", "other");
            pay.AddRequestData("vnp_ReturnUrl", "https://localhost:7142/api/Payment/execute");
            pay.AddRequestData("vnp_TxnRef", tick);
            pay.AddRequestData("vnp_ExpireDate", timeNow.AddMinutes(20).ToString("yyyyMMddHHmmss"));

            var paymentUrl = pay.CreateRequestUrl(_vnPay.BaseUrl, _vnPay.HashSecret);
            return paymentUrl;
        }


        public Task<PaymentSlotResponseModel> PaymentExecuteAsync(IQueryCollection collections)
        {
            throw new NotImplementedException();
        }
    }
}
