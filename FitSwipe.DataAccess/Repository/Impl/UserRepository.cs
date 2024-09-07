using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(FitSwipeDbContext context) : base(context)
        {
        }
    }
}
