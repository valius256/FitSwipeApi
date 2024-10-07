namespace FitSwipe.DataAccess.Model.Entity
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public string UserFirebaseId { get; set; }
        public virtual User User { get; set; }
        public Guid ChatRoomId { get; set; }
        public virtual ChatRoom ChatRoom { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
