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
        public TrainingController(ILogger<Training> logger, ITrainingService trainingService) : base(logger)
        {
            _trainingService = trainingService;
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
        [HttpPost]
        public async Task<ActionResult<GetTrainingDto>> CreateTraining([FromBody] CreateTrainingDto createTrainingDto)
        {
            return await _trainingService.CreateTraining(CurrentUserFirebaseId, createTrainingDto);
        }
    }
}
