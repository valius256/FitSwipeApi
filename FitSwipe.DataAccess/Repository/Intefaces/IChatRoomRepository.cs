using FitSwipe.DataAccess.Model.Entity;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IChatRoomRepository : IGenericRepository<ChatRoom>
    {
        Task<ChatRoom> GetPrivateChatRoomAsync(string userFirebaseId1, string userFirebaseId2);
    }
}
