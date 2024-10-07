using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.Shared.Dtos.Chat
{
    public class ChatRoomRecordDtos
    {
        public string UserFirebaseId { get; set; }
        public Guid ChatRoomId { get; set; }
        public string RoomName { get; set; }
        public GetUserDto User { get; set; }
    }
}
