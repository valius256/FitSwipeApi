using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Enum;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.Shared.Dtos.Users
{
    public class GetUserWithTagDto
    {
        public Guid Id { get; set; }
        public string? FireBaseId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public string AvatarUrl { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string? Bio { get; set; }
        public string City { get; set; } = string.Empty;
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public Role Role { get; set; }
        public string Job { get; set; } = string.Empty;
        public UserStatus Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(7);
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
        //PT Exclusive
        public PTStatus? PTStatus { get; set; }
        public string? Description { get; set; }
        public double? PTExperienceYear { get; set; }
        public double? PTRating { get; set; }
        public int? SubscriptionLevel { get; set; }
        public PaymentStatus? SubscriptionPaymentStatus { get; set; }
        public List<GetTagDto> Tags { get; set; } = new List<GetTagDto>();
    }
}
