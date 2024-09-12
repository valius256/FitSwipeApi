
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Users
{
    public class QueryUserDto
    {
        public string? UserName { get; set; } = string.Empty;
        public List<Gender> Genders { get; set; } = new List<Gender>();
        public string? Email { get; set; }
        public string? Phone { get; set; } = string.Empty;
        public DateTime? DateOfBirthFrom { get; set; }
        public DateTime? DateOfBirthTo { get; set; }
        public double? WeightFrom { get; set; }
        public double? WeightTo { get; set; }
        public double? HeightFrom { get; set; }
        public double? HeightTo { get; set; }
        public string? Bio { get; set; }
        public string? City { get; set; } = string.Empty;
        public string? District { get; set; } = string.Empty;
        public string? Ward { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        public List<Role> Roles { get; set; } = new List<Role>();
        public string? Job { get; set; } = string.Empty;
        public List<UserStatus> Statuses { get; set; } = new List<UserStatus>();
        public DateTime? CreatedDateFrom { get; set; }
        public DateTime? CreatedDateTo { get; set; }
        public DateTime? UpdatedDateFrom { get; set; }
        public DateTime? UpdatedDateTo { get; set; }
        public List<RecordStatus> RecordStatuses { get; set; } = new List<RecordStatus>();
        //Include
        public bool IsIncludeUserTags { get; set; } = false;
    }
}
