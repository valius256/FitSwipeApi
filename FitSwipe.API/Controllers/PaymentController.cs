using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Payment;
using FitSwipe.Shared.Dtos.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : BaseController<PaymentController>
    {
        private readonly IPaymentServices _paymentServices;
        private readonly ILogger<PaymentController> _logger;
        private readonly ITransactionServices _transactionServices;
        private readonly ISlotTransactionServices _slotTransactionServices;

        public PaymentController(IPaymentServices paymentServices, ILogger<PaymentController> logger, ITransactionServices transactionServices, ISlotTransactionServices slotTransactionServices) : base(logger)
        {
            _transactionServices = transactionServices;
            _paymentServices = paymentServices;
            _slotTransactionServices = slotTransactionServices;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("create")]
        public async Task<IActionResult> CreatePaymentForSlotAsync([FromBody] PaySlotDtos model)
        {
            var result = await _paymentServices.CreatePaymentForSlotAsync(model, HttpContext, CurrentUserFirebaseId);
            return Ok(new GetPaymentUrlDto { Url = result });
        }

        [HttpGet("execute")]
        public async Task<IActionResult> PaymentExecute()
        {
            var response = await _paymentServices.PaymentExecuteAsync(Request.Query);
            var redirectTo = Redirect(response.RedirectResult ?? "");
            if (redirectTo == null)
            {
                return Ok(response);
            }
            return redirectTo;
        }

        [HttpPost("transactions")]
        [Authorize]
        public async Task<IActionResult> GetAllTransaction([FromBody] PagingModel<QueryTransactionDtos> pagingModel)
        {
            var result = await _transactionServices.GetTransactionsPageAsync(pagingModel, CurrentUserFirebaseId);
            return Ok(result);
        }

        [HttpPost("create-payos-link")]
        [Authorize]
        public async Task<IActionResult> CreatePaymentWithPayOs([FromBody] PaySlotDtos model)
        {
            var result = await _paymentServices.CreatePaymentForSlotByPayOsAsync(model, CurrentUserFirebaseId);
            if (result == null)
            {
                return BadRequest("Failed");
            }
            return Ok(result);
        }

        [HttpGet("handle-payos-callback")]
        public async Task<IActionResult> HandlePaymentCallback([FromQuery] string code, [FromQuery] string id, [FromQuery] bool cancel, [FromQuery] string status, [FromQuery] int orderCode)
        {
            _logger.LogInformation($"Received payment callback with code: {code}, id: {id}, cancel: {cancel}, status: {status}, orderCode: {orderCode}");
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(status))
            {
                return BadRequest("Invalid payment callback data.");
            }
            var result = await _paymentServices.HandlePayOsCallBackAsync(code, id, cancel, status, orderCode);
            return Ok(status);
        }
    }
}
