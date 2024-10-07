namespace FitSwipe.DataAccess.Model.Entity
{
    public class UserChatRoom : BaseEntity
    {
        public string UserFirebaseId { get; set; }
        public virtual User User { get; set; }

        public Guid ChatRoomId { get; set; }
        public virtual ChatRoom ChatRoom { get; set; }

        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    }
}
