
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class SlotEntityTypeConfiguration : IEntityTypeConfiguration<Slot>
    {
        public void Configure(EntityTypeBuilder<Slot> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.HasOne(s => s.Training)
                .WithMany(t => t.Slots)
                .HasForeignKey(s => s.TrainingId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.CreateBy)
                .WithMany(u => u.SlotsCreated)
                .HasForeignKey(s => s.CreateById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
