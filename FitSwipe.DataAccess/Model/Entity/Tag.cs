using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Tag : BaseEntity //Các tag thể hiện sở thích, thói quen, mục đích tập luyện để phục vụ cho tính năng matching
    {
        public string Name { get; set; }
        public TagType TagType { get; set; }
        public string CreateById { get; set; }
        public string? TagImage { get; set; }
        public SpecialTag? SpecialTag { get; set; }
        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
        public virtual User CreateBy { get; set; } = default!;
    }
}
