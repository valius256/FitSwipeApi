
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class QueryTagDto
    {
        public string? Name { get; set; }
        public List<TagType> TagTypes { get; set; } = new List<TagType>();
        public string? CreateById { get; set; }
        public DateTime? CreatedDateFrom { get; set; }
        public DateTime? CreatedDateTo { get; set; }
    }
}
