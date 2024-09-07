using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

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
        public string AvatarUrl { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string? Bio { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Street { get; set; }
        public Role Role { get; set; }
        public string Job { get; set; }
        public UserStatus Status { get; set; }
        public int Balance { get; set; }
        //PT Exclusive
        public PTStatus? PTStatus { get; set; }
        public double? PTExperienceYear { get; set; }
        public DateTime? SubscriptionPurchasedDate { get; set; }
        public int? SubscriptionLevel { get; set; }
        public PaymentStatus? SubscriptionPaymentStatus { get; set; }
        //Navigator
        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
        public virtual ICollection<Tag> TagsCreated { get; set; } = new List<Tag>();
    }
}
