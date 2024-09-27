
using FitSwipe.BusinessLogic.Interfaces.Slot;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;
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
        [HttpGet]
        public async Task<ActionResult<PagedResult<GetSlotDto>>> GetSlots([FromQuery] PagingModel<QuerySlotDto> pagingModel)
        {
            return await _slotServices.GetSlots(pagingModel);
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



        /// <summary>
        ///  Need in frontend block that the slot only book in days and don;t last to next day
        /// </summary>
        /// <param name="slotId"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        /// <exception cref="DataNotFoundException"></exception>
        /// <exception cref="BadRequestException"></exception>
        [HttpPost("create-slot")]
        [Authorize]
        public async Task<IActionResult> CreateSlotAsync([FromBody] CreateSlotDtos model)
        {
            var result = await _slotServices.CreateSlotAsync(model, CurrentUserFirebaseId);
            return Ok(result);
        }

        [HttpPut("rating")]
        [Authorize]
        public async Task<IActionResult> UpdateRating([FromBody] UpdateSlotRatingDto updateSlotRatingDto)
        {
            await _slotServices.UpdateSlotRating(CurrentUserFirebaseId, updateSlotRatingDto);
            return Ok();
        }


    }
}
