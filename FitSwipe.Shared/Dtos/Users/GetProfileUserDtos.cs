using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Users
{
    public class GetProfileUserDto
    {
        public string? FireBaseId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public string? Bio { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? Street { get; set; }
        public Role Role { get; set; }
        public string? Job { get; set; }
        public UserStatus Status { get; set; }
        public int? Balance { get; set; }
        public PTStatus? PTStatus { get; set; }
        public double? PTExperienceYear { get; set; }
        public double PricePerHour { get; set; }
    }
}
