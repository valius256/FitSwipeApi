namespace FitSwipe.Shared.Dtos.Chat
{
    public class ChatMessageRequest
    {
        public string ChatRoomId { get; set; }
        public string Message { get; set; }
        public bool IsGroup { get; set; }
    }
}
