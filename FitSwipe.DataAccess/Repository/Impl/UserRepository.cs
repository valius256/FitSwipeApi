using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Model.User;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(FitSwipeDbContext context) : base(context)
        {
        }
    }
}
