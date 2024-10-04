using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Trainings;
using FitSwipe.Shared.Enum;

namespace FitSwipe.BusinessLogic.Interfaces.Trainings
{
    public interface ITrainingService
    {
        Task<GetTrainingDto> CreateTraining(string userId, CreateTrainingDto createTrainingDto);
        Task<PagedResult<GetTrainingWithTraineeAndPT>> GetTrainings(string userId, PagingModel<QueryTrainingDto> queryTrainingDto);
        Task<GetTrainingDetailDto> GetDetailById(string userId, Guid id);
        Task<GetTrainingDetailDto> GetDetailById(Guid id);
        Task FeedbackTraining(string userFirebaseId, FeedbackTrainingDto feedbackTrainingDto);


        Task UpdateTrainingStatus(Guid trainingId, TrainingStatus trainingStatus, string? userId);
        Task DeleteTraining(Guid id, string userId);
    }
}
