
using FitSwipe.Shared.Dtos.Medias;
using FitSwipe.Shared.Dtos.Slots;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Trainings;
using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.Shared.Dtos.Users
{
    public class GetUserDetailDto
    {
        public string FireBaseId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? Password { get; set; }
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
        public double PricePerHour { get; set; }
        public UserStatus Status { get; set; }
        public int? Balance { get; set; } = 0;
        //PT Exclusive
        public PTStatus? PTStatus { get; set; }
        public string? Description { get; set; }
        public double? PTExperienceYear { get; set; }
        public double? PTRating { get; set; }
        public string? PTDegreeImageUrl { get; set; }
        public DateTime? SubscriptionPurchasedDate { get; set; }
        public int? SubscriptionLevel { get; set; }
        public PaymentStatus? SubscriptionPaymentStatus { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
        //Navigator
        public virtual ICollection<GetTagDto> Tags { get; set; } = new List<GetTagDto>();
        //public virtual ICollection<GetTagDto> TagsCreated { get; set; } = new List<GetTagDto>();
        public virtual ICollection<GetUserMediaDto> UserMedias { get; set; } = new List<GetUserMediaDto>();
        //public virtual ICollection<Report> ReportsCreated { get; set; } = new List<Report>();
        //public virtual ICollection<Report> ReportsReceived { get; set; } = new List<Report>();
        public virtual ICollection<GetTrainingDto> TrainingsInstructing { get; set; } = new List<GetTrainingDto>();
        public virtual ICollection<GetTrainingDto> TrainingsAttending { get; set; } = new List<GetTrainingDto>();
        //public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public virtual ICollection<GetSlotDto> SlotsCreated { get; set; } = new List<GetSlotDto>();


    }
}
