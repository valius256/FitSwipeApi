using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.BusinessLogic.Interfaces.Trainings
{
    public interface ITrainingService
    {
        Task<GetTrainingDto> CreateTraining(string userId, CreateTrainingDto createTrainingDto);
        Task<PagedResult<GetTrainingWithTraineeAndPT>> GetTrainings(string userId, PagingModel<QueryTrainingDto> queryTrainingDto);
        Task<GetTrainingDetailDto> GetDetailById(string userId, Guid id);
        Task<GetTrainingDetailDto> GetDetailById(Guid id);

    }
}
