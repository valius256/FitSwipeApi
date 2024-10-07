namespace FitSwipe.DataAccess.Model.Entity
{
    public class ChatRoom : BaseEntity
    {
        public string RoomName { get; set; } // Tên của phòng chat
        public bool IsGroup { get; set; } // True nếu là nhóm, False nếu là 1-1

        // Quan hệ nhiều-nhiều với User
        public virtual ICollection<UserChatRoom> UserChatRooms { get; set; } = new List<UserChatRoom>();

        // Tin nhắn trong phòng chat này
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    }
}
