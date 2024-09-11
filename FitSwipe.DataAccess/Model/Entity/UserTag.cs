namespace FitSwipe.DataAccess.Model.Entity
{
    public class UserTag : BaseEntity
    {
        public string UserId { get; set; }
        public Guid TagId { get; set; }
        public virtual User User { get; set; } = default!;
        public virtual Tag Tag { get; set; } = default!;

    }
}
