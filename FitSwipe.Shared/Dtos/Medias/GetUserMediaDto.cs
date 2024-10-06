
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Medias
{
    public class GetUserMediaDto
    {
        public string UserId { get; set; } = string.Empty;
        public string MediaUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RequestStatus Status { get; set; }
    }
}
