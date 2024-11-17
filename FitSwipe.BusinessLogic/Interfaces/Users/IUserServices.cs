using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Management;
using FitSwipe.Shared.Dtos.Transactions;
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
        Task<PagedResult<GetUserWithTagDto>> GetMatchedUserPagedWithTagsOrderedAsync(string userId, int page, int limit);
        Task<GetUserBalanceDto> GetUserBalance(string userId);
        Task UpdatePTDegreeAsync(string userId, UpdateImageUrlDto updateImageUrlDto);
        Task SetupProfileAsync(string userId, SetupProfileDto setupProfileDto);
        Task UpdateAvatarImage(string userId, UpdateUserAvatarDtos updateUserAvatarDtos);
        Task UpdatePTOverallRating(string userId);
        Task UpdateUserBalance(string userId, int amount);
        Task EnableUserSubscription(string userId, int level);
        Task UpdatePTsBalance(List<GetBenefitPTDto> receivers);
        Task<List<GetUserSubscriptionDto>> GetAllUserSubcriptionsExpired();
        Task UpdateUserSubcription(GetUserSubscriptionDto getUserSubscriptionDto);

        Task<GetUserSubscriptionDto> GetUserSubscription(string userId);
        Task<GetDashboardStatDto> GetUserStatistic();
        

    }
}
