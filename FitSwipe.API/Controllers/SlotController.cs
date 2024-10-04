using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlotController : BaseController<SlotController>
    {
        private readonly ISlotServices _slotServices;
        private readonly ISlotVideoServices _slotVideoServices;
        public SlotController(ILogger<SlotController> logger, ISlotServices slotServices, ISlotVideoServices slotVideoServices) : base(logger)
        {
            _slotServices = slotServices;
            _slotVideoServices = slotVideoServices;
        }
        [HttpGet]
        public async Task<ActionResult<PagedResult<GetSlotDto>>> GetSlots([FromQuery] PagingModel<QuerySlotDto> pagingModel)
        {
            return await _slotServices.GetSlots(pagingModel);
        }

        [HttpGet("get-slot-by-id")]
        public async Task<ActionResult<GetSlotDetailDtos>> GetSlotByIdAsync(Guid slotId)
        {
            var slotDetailDtos = await _slotServices.GetSlotByIdAsync(slotId);
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
        [HttpPost("create")]
        [Authorize]
        public async Task<ActionResult<List<GetSlotDto>>> CreateSlotAsync([FromBody] List<CreateSlotDtos> model)
        {
            var result = await _slotServices.CreateFreeSlotForPTAsync(model, CurrentUserFirebaseId);
            return Ok(result);
        }
        [HttpPost("{trainingId}/create")]
        [Authorize]
        public async Task<ActionResult<List<GetSlotDto>>> CreateTrainingSlotAsync([FromRoute] Guid trainingId, [FromBody] List<CreateTrainingSlotDto> model)
        {
            var result = await _slotServices.CreateTrainingSlot(model, trainingId, CurrentUserFirebaseId);
            return Ok(result);
        }
        [HttpPut("rating")]
        [Authorize]
        public async Task<IActionResult> UpdateRating([FromBody] UpdateSlotRatingDto updateSlotRatingDto)
        {
            await _slotServices.UpdateSlotRating(CurrentUserFirebaseId, updateSlotRatingDto);
            return Ok();
        }
        [HttpPut("time")]
        [Authorize]
        public async Task<IActionResult> UpdateTime([FromBody] UpdateSlotTimeDto updateSlotTimeDto)
        {
            await _slotServices.UpdateSlotTime(updateSlotTimeDto, CurrentUserFirebaseId);
            return Ok();
        }
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteSlotAsync(Guid id)
        {
            await _slotServices.DeleteSlotAsync(id, CurrentUserFirebaseId);
            return Ok();
        }

        [HttpPost("upload-slotVideo")]
        [Authorize]
        public async Task<IActionResult> UploadSlotVideo([FromBody] SlotVideoDto slotVideoDtoRequest)
        {
            var currSlot = await _slotServices.GetSlotByIdAsync(slotVideoDtoRequest.SlotId);

            if (currSlot.CreateById != CurrentUserFirebaseId)
            {
                return BadRequest("You are not the owner of this slot so you cannot upload for this slot");
            }

            var createSlotVideoDtos = await _slotVideoServices.AddSlotVideoAsync(slotVideoDtoRequest);

            if (createSlotVideoDtos is null)
            {
                return BadRequest("Can't upload video");
            };
            return Ok(createSlotVideoDtos);
        }

        

    }
}
