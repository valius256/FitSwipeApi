
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserTagRepository : GenericRepository<UserTag>, IUserTagRepository
    {
        private readonly FitSwipeDbContext _context;
        public UserTagRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<UserTag>> GetUserTagWithTagByUserIdAsync(string userId)
        {
            return await _context.UserTags
                .Include(ut => ut.Tag)
                .Where(ut => ut.UserId == userId)
                .ToListAsync();
        }
    }
}
