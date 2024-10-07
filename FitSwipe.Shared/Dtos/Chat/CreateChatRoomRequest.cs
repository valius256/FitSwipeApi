namespace FitSwipe.Shared.Dtos.Chat
{
    public class CreateChatRoomRequest
    {
        public bool IsGroup { get; set; } // True for group chat, False for 1-on-1 chat
        public List<string> UserFirebaseIds { get; set; } // Participants
        public string ChatRoomName { get; set; }
    }
}
