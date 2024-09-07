using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public TagType TagType { get; set; }
        public string CreateById { get; set; }
        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
        public virtual User CreateBy { get; set; } = default!;
    }
}
