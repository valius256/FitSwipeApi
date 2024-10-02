using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.BusinessLogic.Interfaces.Trainings
{
    public interface IFeedbackImageSevices
    {
        Task AddFeedbackImagesAsync(FeedbackImageDtos imageUrl);
    }
}
