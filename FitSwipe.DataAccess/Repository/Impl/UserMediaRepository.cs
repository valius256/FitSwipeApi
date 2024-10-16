

using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserMediaRepository : GenericRepository<UserMedia>, IUserMediaRepository
    {
        private readonly FitSwipeDbContext _context;
        public UserMediaRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
