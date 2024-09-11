
using FitSwipe.Shared.Dtos.Tags;

namespace FitSwipe.BusinessLogic.Interfaces.Tags
{
    public interface IUserTagService
    {
        Task<List<GetTagDto>> GetsTagByUserId(string userId);
        Task UpsertUserTags(string userId, UpsertUserTagDto upsertUserTagDto);
    }
}
