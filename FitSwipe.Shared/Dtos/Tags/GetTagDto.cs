

using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class GetTagDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TagType TagType { get; set; }
        public string? TagImage { get; set; }
        public string CreateById { get; set; } = string.Empty;
        public SpecialTag? SpecialTag { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
