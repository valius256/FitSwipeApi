
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.UploadDowloads
{
    public class UpdateImageUrlDto
    {
        [Required]
        public required string Url { get; set; }
    }
}
