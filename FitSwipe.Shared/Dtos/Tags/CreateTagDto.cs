using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class CreateTagDto
    {
        [Required]
        public required string Name { get; set; } = string.Empty;
        [Required]
        public required TagType TagType { get; set; }
    }
}
