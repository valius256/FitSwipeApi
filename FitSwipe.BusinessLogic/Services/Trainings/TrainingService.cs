
using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.BusinessLogic.Interfaces.UploadDowload;
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
        private readonly IFirebaseUploadDowloadServices _firebaseUploadDowloadServices;
        private readonly ITrainingRepository _trainingRepository;
        private readonly IFeedbackImageSevices _feedbackImageSevices;

        public TrainingService(IUserServices userServices, IFirebaseUploadDowloadServices firebaseUploadDowloadServices,
            ITrainingRepository trainingRepository, IFeedbackImageSevices feedbackImageSevices)
        {
            _userServices = userServices;
            _firebaseUploadDowloadServices = firebaseUploadDowloadServices;
            _trainingRepository = trainingRepository;
            _feedbackImageSevices = feedbackImageSevices;
        }

        public async Task<GetTrainingDto> CreateTraining(string userId, CreateTrainingDto createTrainingDto)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            if (user.Role != Role.Trainee)
            {
                throw new BadRequestException("Only PT can use this feature");
            }

            await _userServices.GetUserByIdRequiredAsync(createTrainingDto.PTId);

            if (createTrainingDto.Status != TrainingStatus.Matched && createTrainingDto.Status != TrainingStatus.NotStarted)
            {
                throw new BadRequestException("Training status must either be Matched or NotStarted");
            }

            // add properties to training entity
            var training = createTrainingDto.Adapt<Training>();
            training.PTId = createTrainingDto.PTId;
            training.TraineeId = userId;


            // add training to database
            var trainningEntity = await _trainingRepository.AddAsync(training);
            return trainningEntity.Adapt<GetTrainingDto>();
        }

        public async Task FeedbackTraining(string userFirebaseId, FeedbackTrainingDto feedbackTrainingDto)
        {
            var trainning = await _trainingRepository.GetTrainingById(feedbackTrainingDto.TrainingId);

            if (trainning == null)
            {
                throw new DataNotFoundException("Training not found");
            }

            if (userFirebaseId != trainning.TraineeId)
            {
                throw new ForbiddenException("You can't feedback for this training cause you are not user used it");
            }

            if (trainning.Status != TrainingStatus.Finished)
            {
                throw new BadRequestException("Training must be finished to feedback");
            }


            // update the rating of trainning 
            trainning.Rating = feedbackTrainingDto.Rating;
            trainning.Feedback = feedbackTrainingDto.Feedback;

            if (feedbackTrainingDto.ImageUrls != null && feedbackTrainingDto.ImageUrls.Any())
            {
                foreach (var image in feedbackTrainingDto.ImageUrls)
                {
                    // 3. Lưu ảnh phản hồi qua FeedbackImageService
                    var imageDto = new FeedbackImageDtos()
                    {
                        MediaUrl = image,
                        TrainingId = feedbackTrainingDto.TrainingId
                    };
                    await _feedbackImageSevices.AddFeedbackImagesAsync(imageDto);
                }
            }
            await _trainingRepository.UpdateAsync(trainning);

        }

        public async Task<GetTrainingDetailDto> GetDetailById(Guid id)
        {
            var training = await _trainingRepository.GetTrainingById(id);
            if (training == null)
            {
                throw new DataNotFoundException("Training not found");
            }
            return training.Adapt<GetTrainingDetailDto>();
        }
        public async Task<GetTrainingDetailDto> GetDetailById(string userId, Guid id)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
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
        public async Task<PagedResult<GetTrainingWithTraineeAndPT>> GetTrainings(string userId, PagingModel<QueryTrainingDto> queryTrainingDto)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
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

        public async Task UpdateTrainingStatus(Guid trainingId, TrainingStatus trainingStatus, string? userId)
        {
            var training = await _trainingRepository.GetByIdAsync(trainingId);
            if (training is null)
            {
                throw new DataNotFoundException("The training is not found");
            }
            if (userId != null && training.PTId != userId)
            {
                throw new ForbiddenException("You don't have permission to do this function");
            }
            if (training.Status == TrainingStatus.Pending && (trainingStatus != TrainingStatus.Rejected && trainingStatus != TrainingStatus.NotStarted))
            {
                throw new BadRequestException("Invalid transistion");
            }
            if (training.Status == TrainingStatus.NotStarted && (trainingStatus != TrainingStatus.Disabled && trainingStatus != TrainingStatus.OnGoing))
            {
                throw new BadRequestException("Invalid transistion");
            }
            if (training.Status == TrainingStatus.OnGoing && (trainingStatus != TrainingStatus.Finished))
            {
                throw new BadRequestException("Invalid transistion");
            }
            if (training.Status == TrainingStatus.Finished)
            {
                throw new BadRequestException("Invalid transistion");
            }
            if (training.Status == TrainingStatus.Disabled && (trainingStatus != TrainingStatus.NotStarted))
            {
                throw new BadRequestException("Invalid transistion");
            }
            if (training.Status == TrainingStatus.Matched && (trainingStatus != TrainingStatus.Pending))
            {
                throw new BadRequestException("Invalid transistion");
            }
            training.Status = trainingStatus;
            await _trainingRepository.UpdateAsync(training);
        }
    }
}
