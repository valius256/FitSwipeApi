using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.Shared.Dtos.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : BaseController<PaymentController>
    {
        private readonly IPaymentServices _paymentServices;

        public PaymentController(IPaymentServices paymentServices, ILogger<PaymentController> logger) : base(logger)
        {
            _paymentServices = paymentServices;
        }

        [Authorize]
        [HttpPost("create-payment-for-slot")]
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
    }
}
