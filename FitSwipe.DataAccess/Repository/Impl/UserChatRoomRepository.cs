using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class UserChatRoomRepository : GenericRepository<UserChatRoom>, IUserChatRoomRepository
    {
        private readonly FitSwipeDbContext _fitSwipeDbContext;
        public UserChatRoomRepository(FitSwipeDbContext context) : base(context)
        {
            _fitSwipeDbContext = context;
        }

        public async Task<List<UserChatRoom>> GetUserChatRoomsByUserFirebaseId(string userFirebaseId)
        {
            return await _fitSwipeDbContext.UserChatRooms.Where(l => l.UserFirebaseId == userFirebaseId)
                .Include(l => l.ChatRoom)
                .Include(l => l.User)
                .OrderBy(l => l.CreatedDate).ToListAsync();
        }
    }
}
