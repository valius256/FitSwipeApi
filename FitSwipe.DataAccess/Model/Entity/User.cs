using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class User : BaseEntity
    {
        [Required]
        public string? FireBaseId { get; set; }
        //public string FisrtName { get; set; }
        //public string LastName { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [AllowNull]
        public string? AvatarUrl { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        [AllowNull]
        public double? Weight { get; set; }
        [AllowNull]
        public double? Height { get; set; }
        [AllowNull]
        public string? Bio { get; set; }
        [AllowNull]
        public string? City { get; set; }
        [AllowNull]
        public string? District { get; set; }
        [AllowNull]
        public string? Ward { get; set; }
        [AllowNull]
        public string? Street { get; set; }
        public Role Role { get; set; }
        [AllowNull]
        public string? Job { get; set; }
        public UserStatus Status { get; set; }

        public int? Balance { get; set; } = 0;
        //PT Exclusive
        [AllowNull]
        public PTStatus? PTStatus { get; set; }
        [AllowNull]
        public string? Description { get; set; }
        [AllowNull]
        public double? PTExperienceYear { get; set; }
        [AllowNull]
        public string? PTDegreeImageUrl { get; set; }
        [AllowNull]
        public DateTime? SubscriptionPurchasedDate { get; set; }
        [AllowNull]
        public int? SubscriptionLevel { get; set; }
        [AllowNull]
        public PaymentStatus? SubscriptionPaymentStatus { get; set; }
        //Navigator
        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
        public virtual ICollection<Tag> TagsCreated { get; set; } = new List<Tag>();
        public virtual ICollection<UserMedia> UserMedias { get; set; } = new List<UserMedia>();
        public virtual ICollection<Report> ReportsCreated { get; set; } = new List<Report>();
        public virtual ICollection<Report> ReportsReceived { get; set; } = new List<Report>();
        public virtual ICollection<Training> TrainingsInstructing { get; set; } = new List<Training>();
        public virtual ICollection<Training> TrainingsAttending { get; set; } = new List<Training>();
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public virtual ICollection<Slot> SlotsCreated { get; set; } = new List<Slot>();

    }
}
