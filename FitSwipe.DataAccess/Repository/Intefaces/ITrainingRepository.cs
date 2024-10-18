using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Trainings;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface ITrainingRepository : IGenericRepository<Training>
    {
        Task<PagedResult<Training>> GetTrainings(PagingModel<QueryTrainingDto> training);
        Task<Training?> GetTrainingById(Guid id);
        Task<GetTrainingOverviewDto?> GetTrainingOverview(Guid id);
        Task<PagedResult<Training>> GetFeedbackTrainingOfPT(string userId, int limit, int page);
    }
}
