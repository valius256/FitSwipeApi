using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Management;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Task<List<User>> GetUsers(QueryUserDto queryUserDto);
        Task<User?> GetUserDetailById(string id);
        Task<PagedResult<User>> GetUsersPaged(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<User>> GetUsersPagedWithTags(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<User>> GetMatchedPTOrdered(GetUserWithTagDto user, int page, int limit);
        Task<User?> GetUserWithTagsById(string id);
        Task<double?> GetNewRatingOfPT(string userId);

        Task<GetDashboardStatDto> GetUserStatistic();
    }
}
