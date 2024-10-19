
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
                throw new BadRequestException("Only Trainee can use this feature");
            }

            await _userServices.GetUserByIdRequiredAsync(createTrainingDto.PTId);
            var existingTraining = await _trainingRepository.FindOneAsync(t => t.PTId == createTrainingDto.PTId && t.TraineeId == userId);
            if (existingTraining != null && existingTraining.Status != TrainingStatus.Finished)
            {
                throw new BadRequestException("There is already an ongoing training for this PT");
            }
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
            trainning.UpdatedDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

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
            await _userServices.UpdatePTOverallRating(userFirebaseId);
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
            var training = (await _trainingRepository.GetTrainingById(id));
            if (training == null)
            {
                throw new DataNotFoundException("Training not found");
            }

            if ((user.Role == Role.Trainee && training.TraineeId != userId) || (user.Role == Role.PT && training.PTId != userId))
            {
                throw new ForbiddenException("You doesn't belong to this training");
            }

            var mappedTraining = training.Adapt<GetTrainingDetailDto>();
            foreach (var slotDto in mappedTraining.Slots)
            {
                var slot = training.Slots.FirstOrDefault(s => s.Id == slotDto.Id)!;
                slotDto.TotalVideo = slot.Videos.Count;
            }
            return mappedTraining;
        }
        public async Task<GetTrainingDetailDto> GetCurrentTraining(string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            var training = await _trainingRepository.FindOneWithNoTrackingAsync(t => t.TraineeId == userId && (t.Status == TrainingStatus.NotStarted || t.Status == TrainingStatus.OnGoing));
            if (training == null)
            {
                throw new DataNotFoundException("No training found");
            }
            return await GetDetailById(userId, training.Id);
        }
        public async Task<Training?> GetSimpleCurrentTraining(string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            var training = await _trainingRepository.FindOneWithNoTrackingAsync(t => t.TraineeId == userId && (t.Status == TrainingStatus.NotStarted || t.Status == TrainingStatus.OnGoing));
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
            var trainings = (await _trainingRepository.GetTrainings(queryTrainingDto)).Adapt<PagedResult<GetTrainingWithTraineeAndPT>>();
            foreach (var training in trainings.Items)
            {
                training.TrainingOverview = await _trainingRepository.GetTrainingOverview(training.Id);
            }
            return trainings;
        }

        public async Task UpdateTrainingStatus(Guid trainingId, TrainingStatus trainingStatus, string? userId)
        {
            var training = await _trainingRepository.GetByIdAsync(trainingId);
            if (training is null)
            {
                throw new DataNotFoundException("The training is not found");
            }

            if (training.Status == TrainingStatus.Pending && (trainingStatus != TrainingStatus.Rejected && trainingStatus != TrainingStatus.NotStarted && trainingStatus != TrainingStatus.Matched))
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

            if (((trainingStatus == TrainingStatus.NotStarted || trainingStatus == TrainingStatus.Rejected) && userId != null && userId != training.PTId)
                || ((trainingStatus == TrainingStatus.Pending || trainingStatus == TrainingStatus.Matched) && userId != null && userId != training.TraineeId))
            {
                throw new ForbiddenException("You don't have permission to do this function");
            }
            training.Status = trainingStatus;
            await _trainingRepository.UpdateAsync(training);
        }

        public async Task DeleteTraining(Guid id, string userId)
        {
            var training = await GetDetailById(id);
            if (training == null)
            {
                throw new DataNotFoundException("Training not found");
            }
            if (training.TraineeId != userId)
            {
                throw new ForbiddenException("You dont have permission to do this");
            }
            if (training.Status != TrainingStatus.Matched)
            {
                throw new BadRequestException("Training must be in Matched status to be deleted");
            }
            if (training.Slots.Count > 0)
            {
                throw new BadRequestException("This training already contains slots. Please use 'Cancel Training Slots' endpoint instead");
            }
            await _trainingRepository.DeleteAsync(id);
        }

        public async Task UpdateTrainingPriceAndApprove(UpdateTrainingPriceDto updateTrainingPriceDto, string userId)
        {
            var training = await GetDetailById(updateTrainingPriceDto.TrainingId);
            if (training.PTId != userId)
            {
                throw new ForbiddenException("You do not have permission to do this");
            }
            foreach (var item in training.Slots)
            {
                if (item.Location == null)
                {
                    throw new BadRequestException("Some of the slots is not updated the location yet!");
                }
            }
            var simpleTraining = (await _trainingRepository.GetByIdAsync(updateTrainingPriceDto.TrainingId))!;
            simpleTraining.PricePerSlot = updateTrainingPriceDto.TrainingPrice;
            simpleTraining.Status = TrainingStatus.NotStarted;
            await _trainingRepository.UpdateAsync(simpleTraining);
        }
        public async Task<PagedResult<GetTrainingFeedbackDetailDto>> GetTrainingFeedbackOfPT(string userId, int limit, int page)
        {
            var result = await _trainingRepository.GetFeedbackTrainingOfPT(userId, limit, page);
            return result.Adapt<PagedResult<GetTrainingFeedbackDetailDto>>();
        }

        public async Task UpdateListTraining(List<Training> trainings)
        {
            await _trainingRepository.UpdateRangeAsync(trainings);
            return;
        }
    }
}
