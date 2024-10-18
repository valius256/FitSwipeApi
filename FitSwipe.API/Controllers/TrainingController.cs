using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Trainings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    [ApiController]
    [Route("api/trainings")]
    public class TrainingController : BaseController<Training>
    {
        private readonly ITrainingService _trainingService;
        private readonly ISlotServices _slotServices;
        public TrainingController(ILogger<Training> logger, ITrainingService trainingService, ISlotServices slotServices) : base(logger)
        {
            _trainingService = trainingService;
            _slotServices = slotServices;
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<PagedResult<GetTrainingWithTraineeAndPT>>> GetTrainings([FromQuery] PagingModel<QueryTrainingDto> queryTrainingDto)
        {
            return await _trainingService.GetTrainings(CurrentUserFirebaseId, queryTrainingDto);
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<GetTrainingDetailDto>> GetTrainingById([FromRoute] Guid id)
        {
            return await _trainingService.GetDetailById(CurrentUserFirebaseId, id);
        }
        [Authorize]
        [HttpGet("current-training")]
        public async Task<ActionResult<GetTrainingDetailDto>> GetCurrentTraining()
        {
            return await _trainingService.GetCurrentTraining(CurrentUserFirebaseId);
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<GetTrainingDto>> CreateTraining([FromBody] CreateTrainingDto createTrainingDto)
        {
            return await _trainingService.CreateTraining(CurrentUserFirebaseId, createTrainingDto);
        }
        [Authorize]
        [HttpPatch("approving")]
        public async Task<IActionResult> ApproveTraining([FromBody] ApproveTrainingDto approveTrainingDto)
        {
            await _slotServices.ApproveTrainingSlots(approveTrainingDto, CurrentUserFirebaseId);
            return Ok();
        }
        [Authorize]
        [HttpPatch("{id}/rejecting")]
        public async Task<IActionResult> RejectTraining([FromRoute] Guid id)
        {
            await _trainingService.UpdateTrainingStatus(id, Shared.Enum.TrainingStatus.Rejected, CurrentUserFirebaseId);
            return Ok();
        }
        [Authorize]
        [HttpPatch("{id}/sending")]
        public async Task<IActionResult> SendTrainingRequest([FromRoute] Guid id)
        {
            await _trainingService.UpdateTrainingStatus(id, Shared.Enum.TrainingStatus.Pending, CurrentUserFirebaseId);
            return Ok();
        }

        [Authorize]
        [HttpPost("rating")]
        public async Task<ActionResult> FeedbackTraning([FromBody] FeedbackTrainingDto feedbackTrainingDto)
        {
            await _trainingService.FeedbackTraining(CurrentUserFirebaseId, feedbackTrainingDto);
            return Ok();
        }
        [HttpPut("finishing")]
        [Authorize]
        public async Task<IActionResult> FinishTraining([FromRoute] Guid id)
        {
            await _slotServices.UpdateSlotsWhenTrainingFinished(CurrentUserFirebaseId);
            return Ok();
        }
        [HttpDelete("{id}/cancel")]
        [Authorize]
        public async Task<IActionResult> CancelTraining([FromRoute] Guid id)
        {
            await _slotServices.CancelTrainingSlots(id, CurrentUserFirebaseId);
            return Ok();
        }
        [Authorize]
        [HttpPatch("update-price")]
        public async Task<IActionResult> UpdateTrainingPriceAndProve([FromBody] UpdateTrainingPriceDto updateTrainingPriceDto)
        {
            await _trainingService.UpdateTrainingPriceAndApprove(updateTrainingPriceDto, CurrentUserFirebaseId);
            return Ok();
        }
        [Authorize]
        [HttpGet("PT-feedback/{userId}")]
        public async Task<IActionResult> GetFeedbackOfPT([FromRoute] string userId, [FromQuery] int limit = 10, [FromQuery] int page = 1)
        {
            await _trainingService.GetTrainingFeedbackOfPT(userId,limit,page);
            return Ok();
        }
    }
}
