using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class ChatRoomRepository : GenericRepository<ChatRoom>, IChatRoomRepository
    {
        private readonly FitSwipeDbContext _context;
        public ChatRoomRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ChatRoom> GetPrivateChatRoomAsync(string userFirebaseId1, string userFirebaseId2)
        {
            var result = await _context.ChatRooms
                .Where(r => !r.IsGroup)
                .FirstOrDefaultAsync(r =>
                    r.UserChatRooms.Any(uc => uc.UserFirebaseId == userFirebaseId1) &&
                    r.UserChatRooms.Any(uc => uc.UserFirebaseId == userFirebaseId2)
                );
            return result;
        }
    }
}
