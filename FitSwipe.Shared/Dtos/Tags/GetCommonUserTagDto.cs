using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class GetCommonUserTagDto
    {
        [Required]
        public required string FirstUserId { get; set; }
        [Required]
        public required string SecondUserId { get; set; }
    }
}
