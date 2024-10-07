using FitSwipe.Shared.Dtos.Chat;

namespace FitSwipe.BusinessLogic.Interfaces.Chats
{
    public interface IChatServices
    {
        Task<Guid?> CreateChatRoomAsync(bool isGroup, List<string> userFirebaseIds, string roomName);
        Task SaveMessageAsync(string chatRoomId, string message, string userFirebaseId);
        Task<Guid> CreateSoloChatAsync(string userFirebaseId1, string userFirebaseId2);
        Task<List<MessageRecordDtos>> GetAllGroupChatMessageFromGroupChatIdAsync(Guid chatRoomId);
        Task<List<ChatRoomRecordDtos>> GetAllChatRoomByUserFirebaseIdAsync(string userFirebaseId);
    }
}
