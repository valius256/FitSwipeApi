using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.Shared.Dtos.Chat
{
    public class ChatRoomRecordDtos
    {
        public string UserFirebaseId { get; set; } = string.Empty;
        public Guid ChatRoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<GetSimpleUserChatRoomDto> Users { get; set; } = [];
    }
}
