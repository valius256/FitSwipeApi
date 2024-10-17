using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Dtos.Payment;
using FitSwipe.Shared.Dtos.Transactions;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Net.payOS;
using Net.payOS.Types;

namespace FitSwipe.BusinessLogic.Services.Payments
{
    public class PaymentServices : IPaymentServices
    {
        private readonly IUserServices _userServices;
        private readonly ISlotServices _slotServices;
        private readonly ITransactionServices _transactionServices;
        private readonly VnPay _vnPay;
        private readonly PayOsOption _payOs;
        public PaymentServices(IUserServices userServices, ISlotServices slotServices, IOptions<VnPay> vnPay, ITransactionServices transactionServices, IOptions<PayOsOption> payOs)
        {
            _userServices = userServices;
            _transactionServices = transactionServices;
            _slotServices = slotServices;
            _vnPay = vnPay.Value;
            _payOs = payOs.Value;
        }

        public async Task<string> CreatePaymentForSlotAsync(PaySlotDtos model, HttpContext context, string currentUserFirebaseId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(currentUserFirebaseId);

            if (user is null)
            {
                throw new ModelException(nameof(User), "Người dùng không khả dụng");
            }

            // Initialize total cost
            double totalCost = 0;

            // Validate each slot
            foreach (var slotId in model.GetSlotGuids())
            {
                var slotDetailDtos = await _slotServices.GetSlotByIdAsync(slotId);
                if (slotDetailDtos is null)
                {
                    throw new ModelException("Slot", $"Slot {slotId} không tồn tại");
                }
                //NOT NECCESSARY (YET)
                //var isSlotValid = await _slotServices.ValidateSlotForCustomer(slotDetailDtos.StartTime, slotDetailDtos.EndTime, user.FireBaseId);
                //if (!isSlotValid)
                //{
                //    throw new ModelException("Slot", $"Slot {slotId} không hợp lệ do trùng lịch với 1 slot khác");
                //}

                //var ptOfSlot = await _userServices.GetSimpleUser(slotDetailDtos.CreateById.ToString());

                //if (ptOfSlot is null || ptOfSlot.PTStatus != PTStatus.Active || ptOfSlot.PricePerHour <= 0 || ptOfSlot.Status != UserStatus.Active)
                //{
                //    throw new ModelException("PT", $"PT cho Slot {slotId} chưa đủ điều kiện dạy");
                //}
                if (slotDetailDtos.PaymentStatus != PaymentStatus.NotPaid)
                {
                    throw new BadRequestException("Invalid payment status");
                }
                if (slotDetailDtos.Training == null || slotDetailDtos.Training.PricePerSlot == null)
                {
                    throw new BadRequestException("Slot is not on a training");
                }
                // Calculate cost for the slot and add to total cost
                var slotCost = slotDetailDtos.Training.PricePerSlot.Value;
                totalCost += slotCost;
            }

            var lastOrderDescription = model.OrderDescription?.Trim() ?? "";
            var lastUrl = model.ReturnUrl?.Trim() ?? "";
            var tick = DateTime.Now.Ticks.ToString();

            // Create payment URL for multiple slots
            var paymentUrl = CreateVnPayRequest(model, context, model.GetSlotGuids(), totalCost, lastOrderDescription, false, tick, lastUrl, OrderType.Slots);
            return paymentUrl;
        }

        private string CreateVnPayRequest<T>(T model, HttpContext context, List<Guid>? slotId, double amount, string? description, bool? isRechargePayment, string tick, string? returnPage, OrderType orderType)
        {
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_vnPay.TimeZoneId);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var pay = new VnPayLibrary();

            var currUid = context.User.FindFirst(c => c.Type == "user_id")?.Value;
            string slotIdString = slotId != null ? string.Join(",", slotId.Select(id => id.ToString())) : string.Empty;
            pay.AddRequestData("vnp_Version", _vnPay.Version);
            pay.AddRequestData("vnp_Command", _vnPay.Command);
            pay.AddRequestData("vnp_TmnCode", _vnPay.TmnCode);
            pay.AddRequestData("vnp_Amount", ((int)amount * 100).ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _vnPay.CurrCode);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _vnPay.Locale);
            pay.AddRequestData("vnp_OrderInfo", $"{isRechargePayment}|{description}|{currUid}|{returnPage}|{orderType.ToString()}|{slotIdString}");
            pay.AddRequestData("vnp_OrderType", "other");
            pay.AddRequestData("vnp_ReturnUrl", "https://fitandswipeapi.somee.com/api/Payment/execute");
            pay.AddRequestData("vnp_TxnRef", tick);
            pay.AddRequestData("vnp_ExpireDate", timeNow.AddMinutes(20).ToString("yyyyMMddHHmmss"));

            var paymentUrl = pay.CreateRequestUrl(_vnPay.BaseUrl, _vnPay.HashSecret);
            return paymentUrl;
        }


        public async Task<PaymentSlotResponseModel> PaymentExecuteAsync(IQueryCollection collections)
        {
            var pay = new VnPayLibrary();
            var response = pay.GetFullResponseData(collections, _vnPay.HashSecret);
            if (response.Success)
            {
                if (response.OrderType == OrderType.Slots)
                {
                    await HandleSlotsPayment(response);
                }


                var createTransactionDtos = new CreateTransactionDtos
                {
                    TranscationCode = response.TransactionCode,
                    UserFireBaseId = response.UserFireBaseId,
                    Amount = (int)response.Money,
                    Method = TransactionMethod.VnPay,
                    SlotIds = response.SlotIds,
                    Description = response.OrderDescription
                };

                // Create the transaction in the service
                await _transactionServices.CreateTransactionAsync(createTransactionDtos);

            }
            else if (response.VnPayResponseCode == "24")
            {
                throw new BadRequestException("Giao dịch đã bị hủy");
            }

            return response;
        }

        private async Task HandleSlotsPayment(PaymentSlotResponseModel paymentSlotResponseModel)
        {
            await _slotServices.UpdateRangePayment(paymentSlotResponseModel.SlotIds);
        }

        public async Task HandleSlotsPayment(List<Guid> slotIds)
        {
            await _slotServices.UpdateRangePayment(slotIds);
        }


        public async Task<string> CreatePaymentForSlotByPayOsAsync(PaySlotDtos model, string CurrentUserFirebaseId)
        {

            var user = await _userServices.GetUserByIdRequiredAsync(CurrentUserFirebaseId);


            if (user is null)
            {
                throw new ModelException(nameof(User), "Người dùng không khả dụng");
            }

            int totalCost = 0;

            List<ItemData> items = new List<ItemData>();

            foreach (var slotId in model.GetSlotGuids())
            {
                var slotDetailDtos = await _slotServices.GetSlotByIdAsync(slotId);

                // Check if slot exists
                if (slotDetailDtos is null)
                {
                    throw new ModelException("Slot", $"Slot {slotId} không tồn tại");
                }

                // Check if the slot's payment status is 'NotPaid'
                if (slotDetailDtos.PaymentStatus != PaymentStatus.NotPaid)
                {
                    throw new BadRequestException("Invalid payment status");
                }

                // Check if slot has a valid training session with a price
                if (slotDetailDtos.Training == null || slotDetailDtos.Training.PricePerSlot == null)
                {
                    throw new BadRequestException("Slot is not on a valid training session");
                }

                // Calculate cost for the slot and add to the total cost
                var slotCost = slotDetailDtos.Training.PricePerSlot.Value;
                totalCost += slotCost;

                string slotTime = slotDetailDtos.StartTime + "to" + slotDetailDtos.EndTime + "of" + slotDetailDtos.Training.PT.UserName;
                // Add slot item data to the list
                ItemData item = new ItemData(slotTime, 1, slotCost);
                items.Add(item);
            }



            var Content = "Thanh toán cho buổi tập";
            var lastUrl = model.ReturnUrl?.Trim() ?? "";
            var tick = DateTime.UtcNow.Ticks;

            var cancelUrl = string.Empty; // example   cancelUrl="https://localhost:3002"
            var successUrl = "https://fitandswipeapi.somee.com/api/payment/handle-payos-callback"; // example   returnUrl="https://localhost:3002"


            PayOS payOs = new PayOS(_payOs.ClientID, _payOs.APIKey, _payOs.ChecksumKey);
            long paymentCode = GenerateUniqueOrderCode();
            PaymentData paymentData = new PaymentData(paymentCode, totalCost, Content, items, cancelUrl, successUrl);
            CreatePaymentResult createPayment = await payOs.createPaymentLink(paymentData);

            // create a trasaction for the payment
            var createTransactionDtos = new CreateTransactionDtos
            {
                TranscationCode = createPayment.orderCode.ToString(),
                UserFireBaseId = CurrentUserFirebaseId,
                Amount = totalCost,
                Method = TransactionMethod.PayOs,
                Description = Content,
                SlotIds = model.GetSlotGuids()
            };
            await _transactionServices.CreateTransactionAsync(createTransactionDtos);


            return createPayment.checkoutUrl;
        }

        public long GenerateUniqueOrderCode()
        {
            Random random = new Random();
            long orderCode = random.Next(100000000, 999999999);
            return orderCode;
        }


    }

}
