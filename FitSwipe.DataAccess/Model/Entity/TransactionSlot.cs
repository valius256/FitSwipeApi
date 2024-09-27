namespace FitSwipe.DataAccess.Model.Entity
{
    public class TransactionSlot : BaseEntity
    {
        public Guid SlotId { get; set; }
        public Guid TransactionId { get; set; }

        // Navigation properties
        public virtual Slot Slot { get; set; } = default!;
        public virtual Transaction Transaction { get; set; } = default!;
    }
}
