using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.BusinessLogic.Services.Trainings
{
    public class FeedbackImageSevices : IFeedbackImageSevices
    {
        private readonly IFeedbackImageRepository _feedbackImageRepository;

        public FeedbackImageSevices(IFeedbackImageRepository feedbackImageRepository)
        {
            _feedbackImageRepository = feedbackImageRepository;
        }

        public async Task AddFeedbackImagesAsync(FeedbackImageDtos imageDto)
        {
            var feedbackImage = new FeedbackImage
            {
                MediaUrl = imageDto.MediaUrl,
                TrainingId = imageDto.TrainingId
            };
            await _feedbackImageRepository.AddAsync(feedbackImage);
        }
    }
}
