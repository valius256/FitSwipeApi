using FitSwipe.Shared.Enum;

namespace FitSwipe.DataAccess.Model
{
    public interface IBaseEntity { }

    public abstract class BaseEntityEmpty : IBaseEntity
    {
        public Guid Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntityEmpty, IBaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public RecordStatus RecordStatus { get; set; }
    }
}
