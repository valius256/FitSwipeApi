using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Users
{
    public class UserFilterModel
    {
        public string? UserName { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }


    }
}
