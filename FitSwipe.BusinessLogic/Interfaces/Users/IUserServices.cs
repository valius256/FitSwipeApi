using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.UploadDowloads;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Users
{
    public interface IUserServices
    {
        Task<User> AddUserAsync(User user);
        Task<GetProfileUserDto> GetProfileUser(string userFirebaseId);
        Task<List<User>> GetAllUserAsync();
        Task<User?> GetUserByEmail(string email);
        Task<User> GetUserByIdRequired(string id);
        Task<PagedResult<GetUserDto>> GetUserPaged(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTags(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<GetUserWithTagDto>> GetMatchedUserPagedWithTagsOrdered(List<Guid> tagIds, int page, int limit);
        Task UpdatePTDegree(string userId, UpdateImageUrlDto updateImageUrlDto);
        Task SetupProfile(string userId, SetupProfileDto setupProfileDto);
    }
}
