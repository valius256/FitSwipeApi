
using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.Shared.Model.Slot;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlotController : BaseController<SlotController>
    {
        private readonly ISlotServices _slotServices;

        public SlotController(ILogger<SlotController> logger, ISlotServices slotServices) : base(logger)
        {
            _slotServices = slotServices;
        }

        [HttpGet("get-slot-by-id")]
        public async Task<IActionResult> GetSlotByIdAsync(Guid slotId)
        {
            var slotDetailDtos = await _slotServices.GetSlotByIdAsync(slotId);
            if (slotDetailDtos is null)
            {
                return NotFound();
            }
            return Ok(slotDetailDtos);
        }

        [HttpPost("create-slot")]
        [Authorize]
        public async Task<IActionResult> CreateSlotAsync([FromBody] CreateSlotDtos model)
        {
            var result = await _slotServices.CreateSlotAsync(model, CurrentUserFirebaseId);
            return Ok(result);
        }






    }
}
