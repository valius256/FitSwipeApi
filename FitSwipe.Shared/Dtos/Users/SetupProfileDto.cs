using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Users
{
    public class SetupProfileDto
    {
        public Gender? Gender { get; set; }
        public string? AvatarUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Bio { get; set; }
        public string? City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Job { get; set; }
    }
}
