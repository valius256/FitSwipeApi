
namespace FitSwipe.DataAccess.Model.Entity
{
    public class ReportImage : BaseEntity
    {
        public string MediaUrl { get; set; }
        public Guid ReportId { get; set; }
        public virtual Report Report { get; set; } = default!;
    }
}
