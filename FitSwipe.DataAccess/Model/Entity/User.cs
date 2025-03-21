﻿using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class User : BaseEntity
    {
        public string FireBaseId { get; set; }
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
        public double? Latitude { get; set; }
        [AllowNull]
        public double? Longitude { get; set; }
        [AllowNull]
        public string? City { get; set; }
        [AllowNull]
        public Role Role { get; set; }
        [AllowNull]
        public string? Job { get; set; }
        public double PricePerHour { get; set; }
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
        public double? PTRating { get; set; }
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
        public virtual ICollection<RequestWithdraw> RequestWithdrawsCreated { get; set; } = new List<RequestWithdraw>();
        public virtual ICollection<RequestWithdraw> RequestWithdrawsHandled { get; set; } = new List<RequestWithdraw>();
        public ICollection<UserChatRoom> UserChatRooms { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();

    }
}
