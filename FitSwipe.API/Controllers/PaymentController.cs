using FitSwipe.BusinessLogic.Interfaces.Payments;
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

        public PaymentController(IPaymentServices paymentServices, ILogger<PaymentController> logger, ITransactionServices transactionServices) : base(logger)
        {
            _transactionServices = transactionServices;
            _paymentServices = paymentServices;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("create")]
        public async Task<IActionResult> CreatePaymentForSlotAsync([FromBody] PaySlotDtos model)
        {
            var result = await _paymentServices.CreatePaymentForSlotAsync(model, HttpContext, CurrentUserFirebaseId);
            return Ok(result);
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
    }
}
