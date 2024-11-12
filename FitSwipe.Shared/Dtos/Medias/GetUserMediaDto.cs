
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Medias
{
    public class GetUserMediaDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string MediaUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsVideo { get; set; } = false;
        public RequestStatus Status { get; set; }
    }
}
