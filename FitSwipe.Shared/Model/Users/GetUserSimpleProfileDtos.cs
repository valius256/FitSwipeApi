using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Model.Users
{
    public class GetUserSimpleProfileDtos
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Bio { get; set; }
        public Role Role { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Street { get; set; }

    }
}
