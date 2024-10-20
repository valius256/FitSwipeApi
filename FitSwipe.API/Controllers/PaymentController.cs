using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Payment;
using FitSwipe.Shared.Dtos.RequestWithdraw;
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
        private readonly IRequestWithdrawService _requestWithdrawService;

        public PaymentController(IPaymentServices paymentServices, ILogger<PaymentController> logger, 
            ITransactionServices transactionServices, ISlotTransactionServices slotTransactionServices,
            IRequestWithdrawService requestWithdrawService) : base(logger)
        {
            _transactionServices = transactionServices;
            _paymentServices = paymentServices;
            _slotTransactionServices = slotTransactionServices;
            _requestWithdrawService = requestWithdrawService;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("vnpay-create")]
        public async Task<IActionResult> CreatePaymentForSlotAsync([FromBody] PaySlotDtos model)
        {
            var result = await _paymentServices.CreatePaymentForSlotAsync(model, HttpContext, CurrentUserFirebaseId);
            return Ok(new GetPaymentUrlDto { Url = result });
        }

        [HttpGet("vnpay-execute")]
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

        [HttpGet("transactions")]
        [Authorize]
        public async Task<IActionResult> GetAllTransaction([FromQuery] PagingModel<QueryTransactionDtos> pagingModel)
        {
            var result = await _transactionServices.GetTransactionsPageAsync(pagingModel, CurrentUserFirebaseId);
            return Ok(result);
        }

        [HttpPost("payos-create")]
        [Authorize]
        public async Task<IActionResult> CreatePaymentWithPayOs([FromBody] PaySlotDtos model)
        {
            var result = await _paymentServices.CreatePaymentForSlotByPayOsAsync(model, CurrentUserFirebaseId);
            if (result == null)
            {
                return BadRequest("Failed");
            }
            return Ok(new GetPaymentUrlDto { Url = result });
        }
        [HttpPost("payos-create-deposit")]
        [Authorize]
        public async Task<IActionResult> CreatePaymentDepositWithPayOs([FromQuery] int amount)
        {
            var result = await _paymentServices.CreatePaymentRecharge(CurrentUserFirebaseId, amount);
            if (result == null)
            {
                return BadRequest("Failed");
            }
            return Ok(new GetPaymentUrlDto { Url = result });
        }

        [HttpGet("payos-callback")]
        public async Task<IActionResult> HandlePaymentCallback([FromQuery] string code, [FromQuery] string id, [FromQuery] bool cancel, [FromQuery] string status, [FromQuery] int orderCode)
        {
            _logger.LogInformation($"Received payment callback with code: {code}, id: {id}, cancel: {cancel}, status: {status}, orderCode: {orderCode}");
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(status))
            {
                return BadRequest("Invalid payment callback data.");
            }
            var result = await _paymentServices.HandlePayOsCallBackAsync(code, id, cancel, status, orderCode);
            var redirectTo = Redirect("fitswipe://payment-completed");
            if (redirectTo == null)
            {
                return Ok(result);
            }
            return redirectTo;
        }
        [HttpPut("balance-payment")]
        [Authorize]
        public async Task<IActionResult> HandlePaymentSlotsWithBalance([FromBody] List<Guid> slotIds)
        {
            await _paymentServices.HandleSlotsPaymentWithBalance(slotIds, CurrentUserFirebaseId);
            return Ok();
        }
        [Authorize]//Role Operator
        [HttpGet("withdraw-all")]
        public async Task<ActionResult<PagedResult<GetRequestWithdrawDto>>> GetAllWithdrawRequestPaged([FromQuery] int limit = 10, [FromQuery] int page = 1)
        {
            return await _requestWithdrawService.GetAllRequestWithdraw(limit, page);
        }
        [Authorize]
        [HttpGet("withdraw-user")]
        public async Task<ActionResult<PagedResult<GetRequestWithdrawDto>>> GetAllWithdrawRequestOfOneUserPaged([FromQuery] int limit = 10, [FromQuery] int page = 1)
        {
            return await _requestWithdrawService.GetRequestWithdrawOfUser(CurrentUserFirebaseId,limit, page);
        }
        [Authorize]
        [HttpPost("withdraw")]
        public async Task<ActionResult<GetRequestWithdrawDto>> CreateWithdrawRequest([FromBody] CreateRequestWithdrawDto createRequestWithdrawDto)
        {
            return await _requestWithdrawService.CreateRequestWithdraw(createRequestWithdrawDto, CurrentUserFirebaseId);
        }
        [Authorize]
        [HttpPatch("withdraw")]
        public async Task<ActionResult<GetRequestWithdrawDto>> UpdateWithdrawRequest([FromBody] UpdateRequestWithdrawDto updateRequestWithdrawDto)
        {
            return await _requestWithdrawService.UpdateRequestWithdraw(updateRequestWithdrawDto, CurrentUserFirebaseId);
        }
        [Authorize]
        [HttpDelete("withdraw/{id}")]
        public async Task<IActionResult> DeleteWithdrawRequest([FromRoute] Guid id)
        {
            await _requestWithdrawService.DeleteRequestWithdraw(id,CurrentUserFirebaseId);
            return Ok();
        }
    }
}
