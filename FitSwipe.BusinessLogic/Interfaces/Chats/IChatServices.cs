using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.Chat;

namespace FitSwipe.BusinessLogic.Interfaces.Chats
{
    public interface IChatServices
    {
        Task<Guid?> CreateChatRoomAsync(bool isGroup, List<string> userFirebaseIds, string roomName);
        Task SaveMessageAsync(string chatRoomId, string message, string userFirebaseId);
        Task<Guid> CreateSoloChatAsync(string userFirebaseId1, string userFirebaseId2);
        Task<PagedResult<MessageRecordDtos>> GetMessagesOfTheRoomWith(string yourId, string guestId, int limit, int page);
        Task<List<ChatRoomRecordDtos>> GetAllChatRoomByUserFirebaseIdAsync(string userFirebaseId);
        Task UpdateViewedUnseenMessages(Guid chatRoomId, string userId);
        Task<ChatRoomRecordDtos> GetChatRoomDetailByIdAsync(Guid chatRoomId, string userFirebaseId);
    }
}
