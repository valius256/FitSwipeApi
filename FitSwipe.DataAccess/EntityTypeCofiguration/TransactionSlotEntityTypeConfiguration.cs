using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class TransactionSlotEntityTypeConfiguration : IEntityTypeConfiguration<TransactionSlot>
    {
        public void Configure(EntityTypeBuilder<TransactionSlot> builder)
        {
            builder.HasKey(ts => new { ts.SlotId, ts.TransactionId });

            builder.HasOne(ts => ts.Slot)
                .WithMany(s => s.TransactionSlots)
                .HasForeignKey(ts => ts.SlotId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(ts => ts.Transaction)
                .WithMany(t => t.TransactionSlots)
                .HasForeignKey(ts => ts.TransactionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
