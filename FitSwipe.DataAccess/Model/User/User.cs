using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Model.User
{
    public class User : IBaseEntity
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
        public List<Sport>? FavoriteSport { get; set; }
    }
}
