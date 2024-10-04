using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Task<List<User>> GetUsers(QueryUserDto queryUserDto);
        Task<PagedResult<User>> GetUsersPaged(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<User>> GetUsersPagedWithTags(PagingModel<QueryUserDto> pagingModel);
        Task<PagedResult<User>> GetMatchedPTOrdered(List<Guid> tagIds, string userId, int page, int limit);
    }
}
