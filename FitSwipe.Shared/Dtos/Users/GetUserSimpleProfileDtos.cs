using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Users
{
    public class GetUserSimpleProfileDtos
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Bio { get; set; }
        public Role Role { get; set; }
        public required string City { get; set; }
        public required string District { get; set; }
        public required string Ward { get; set; }
        public required string Street { get; set; }

    }
}
