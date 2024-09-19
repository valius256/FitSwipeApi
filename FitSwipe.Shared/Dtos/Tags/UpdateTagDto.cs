using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class UpdateTagDto
    {
        [Required]
        public required Guid Id { get; set; }

        public string? Name { get; set; }
        public TagType? TagType { get; set; }
    }
}
