using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        Task<PagedResult<Message>> GetAllChatMessageWithChatRoomIdAsync(Guid chatRoomId, int limit, int skip);
    }
}
