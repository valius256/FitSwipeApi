using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.UploadDowloads;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Users
{
    public interface IUserServices
    {
        Task<User?> AddUserAsync(User user);
        Task<GetUserDto> GetSimpleUser(string userFirebaseId);
        Task<GetUserDetailDto> GetUserDetail(string userFirebaseId);
        Task<List<User>> GetAllUserAsync();
        Task<User?> GetUserByEmailAsync(string email);
        Task<User> GetUserByIdRequiredAsync(string id);
        Task<PagedResult<GetUserDto>> GetUserPagedAsync(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTagsAsync(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<GetUserWithTagDto>> GetMatchedUserPagedWithTagsOrderedAsync(List<Guid> tagIds, string userId, int page, int limit);
        Task UpdatePTDegreeAsync(string userId, UpdateImageUrlDto updateImageUrlDto);
        Task SetupProfileAsync(string userId, SetupProfileDto setupProfileDto);
        Task UpdateAvatarImage(string userId, UpdateUserAvatarDtos updateUserAvatarDtos);
    }
}
