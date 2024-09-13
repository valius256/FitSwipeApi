
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Tags
{
    public interface IUserTagService
    {
        Task<List<GetTagDto>> GetsTagByUserId(string userId);
        Task UpsertUserTags(string userId, UpsertUserTagDto upsertUserTagDto);
        Task<List<GetTagDto>> GetCommonTags(string firstUserId, string secondUserId);
        Task<PagedResult<GetUserWithTagDto>> GetRecommendedPTListByTags(string userId, int page, int limit);
    }
}
