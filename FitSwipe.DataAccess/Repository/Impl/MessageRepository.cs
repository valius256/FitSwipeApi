using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Repository.Impl
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        private readonly FitSwipeDbContext _context;
        public MessageRepository(FitSwipeDbContext context) : base(context)
        {
            _context = context;

        }

        public async Task<List<Message>> GetAllChatMessageWithChatRoomIdAsync(Guid chatRoomId)
        {
            return await _context.Messages.Where(ld => ld.ChatRoomId == chatRoomId).OrderBy(l => l.SentAt).ToListAsync();
        }
    }
}
