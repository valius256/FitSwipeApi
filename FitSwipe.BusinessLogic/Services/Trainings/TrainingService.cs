
using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Trainings;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Trainings
{
    public class TrainingService : ITrainingService
    {
        private readonly IUserServices _userServices;
        private readonly ITrainingRepository _trainingRepository;

        public TrainingService(IUserServices userServices, ITrainingRepository trainingRepository)
        {
            _userServices = userServices;
            _trainingRepository = trainingRepository;
        }

        public async Task<GetTrainingDto> CreateTraining(string userId, CreateTrainingDto createTrainingDto)
        {
            var user = await _userServices.GetUserByIdRequired(userId);
            if (user.Role != Role.Trainee)
            {
                throw new BadRequestException("Only trainee can use this feature");
            }

            await _userServices.GetUserByIdRequired(createTrainingDto.PTId);

            if (createTrainingDto.Status != TrainingStatus.Matched && createTrainingDto.Status != TrainingStatus.NotStarted)
            {
                throw new BadRequestException("Training status must either be Matched or NotStarted");
            }

            var training = createTrainingDto.Adapt<Training>();
            training.TraineeId = userId;

            await _trainingRepository.AddAsync(training);
            return training.Adapt<GetTrainingDto>();
        }

        public async Task<GetTrainingDetailDto> GetDetailById(Guid id)
        {
            return (await _trainingRepository.GetTrainingById(id)).Adapt<GetTrainingDetailDto>();
        }
        public async Task<GetTrainingDetailDto> GetDetailById(string userId, Guid id)
        {
            var user = await _userServices.GetUserByIdRequired(userId);
            var training = (await _trainingRepository.GetTrainingById(id)).Adapt<GetTrainingDetailDto>();
            if (training == null)
            {
                throw new DataNotFoundException("Training not found");
            }
            if ((user.Role == Role.Trainee && training.TraineeId != userId) || (user.Role == Role.PT && training.PTId != userId))
            {
                throw new ForbiddenException("You doesn't belong to this training");
            }
            return training;
        }
        public async Task<PagedResult<GetTrainingWithTraineeAndPT>> GetTrainings(string userId ,PagingModel<QueryTrainingDto> queryTrainingDto)
        {
            var user = await _userServices.GetUserByIdRequired(userId);
            if (queryTrainingDto.Filter == null)
            {
                queryTrainingDto.Filter = new QueryTrainingDto();
            }
            if (user.Role == Role.Trainee)
            {             
                queryTrainingDto.Filter.TraineeId = userId;
            }
            if (user.Role == Role.PT)
            {
                queryTrainingDto.Filter.PTId = userId;
            }
            return (await _trainingRepository.GetTrainings(queryTrainingDto)).Adapt<PagedResult<GetTrainingWithTraineeAndPT>>();
        }
    }
}
