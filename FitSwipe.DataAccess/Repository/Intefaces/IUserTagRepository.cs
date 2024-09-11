using FitSwipe.DataAccess.Model.Entity;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IUserTagRepository : IGenericRepository<UserTag>
    {
        Task<List<UserTag>> GetUserTagWithTagByUserIdAsync(string userId);
    }
}
