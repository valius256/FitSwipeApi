using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model.Entity
{
    public class Report : BaseEntity
    {
        public string ReporterId {  get; set; }
        public string TargetId { get; set; }
        public string Reason { get; set; }
        public RequestStatus Status { get; set; }
        public virtual User Reporter { get; set; } = default!;
        public virtual User Target { get; set; } = default!;
        public virtual ICollection<ReportImage> ReportImages { get; set; } = new List<ReportImage>();

    }
}
