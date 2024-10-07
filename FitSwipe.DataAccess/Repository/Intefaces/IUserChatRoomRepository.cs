using FitSwipe.DataAccess.Model.Entity;

namespace FitSwipe.DataAccess.Repository.Intefaces
{
    public interface IUserChatRoomRepository : IGenericRepository<UserChatRoom>
    {
        Task<List<UserChatRoom>> GetUserChatRoomsByUserFirebaseId(string userFirebaseId);
    }
}
