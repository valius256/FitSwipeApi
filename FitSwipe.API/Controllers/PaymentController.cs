using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.Shared.Model.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : BaseController<PaymentController>
    {
        private readonly ISlotServices _slotServices;
        private readonly IPaymentServices _paymentServices;

        public PaymentController(IPaymentServices paymentServices, ISlotServices slotServices, ILogger<PaymentController> logger) : base(logger)
        {
            _slotServices = slotServices;
            _paymentServices = paymentServices;
        }

        [Authorize]
        [HttpPost("create-payment-for-slot")]
        public async Task<IActionResult> CreatePaymentForSlotAsync([FromBody] PaySlotDtos model)
        {
            var slotDetailDtos = await _slotServices.GetSlotByIdAsync(model.SlotId);
            if (slotDetailDtos is null)
            {
                return BadRequest("Slot này không tồn tại. Bạn vui lòng chọn slot khác");
            }
            var result = await _paymentServices.CreatePaymentForSlotAsync(model, HttpContext, slotDetailDtos, CurrentUserFirebaseId);
            return Ok(result);
        }
    }
}
