
using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class UserMedia : BaseEntity
    {
        public string UserId { get; set; }
        public string MediaUrl { get; set; }
        public bool IsVideo { get; set; }
        public string Description { get; set; }
        public RequestStatus Status { get; set; }
        public virtual User User { get; set; } = default!;
    }
}
