using FitSwipe.DataAccess.Model.Entity;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        Task<List<Message>> GetAllChatMessageWithChatRoomIdAsync(Guid chatRoomId);
    }
}
