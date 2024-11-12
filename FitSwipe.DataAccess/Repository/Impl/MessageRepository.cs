using FitSwipe.DataAccess.Helper;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
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

        public async Task<PagedResult<Message>> GetAllChatMessageWithChatRoomIdAsync(Guid chatRoomId, int limit, int skip)
        {
            limit = limit > 0 ? limit : 10;
            var query = _context.Messages.Where(ld => ld.ChatRoomId == chatRoomId)
                .OrderByDescending(l => l.SentAt);

            return new PagedResult<Message>
            {
                Items = await query
                        .Skip(skip)
                        .Take(limit).ToListAsync(),
                Errors = [],
                Limit = limit,
                Page = 0,
                Total = await query.CountAsync()
            };
        }
    }
}
