
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class TrainingEntityTypeConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasOne(t => t.Trainee)
                .WithMany(u => u.TrainingsAttending)
                .HasForeignKey(t => t.TraineeId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(t => t.PT)
            //    .WithMany(u => u.TrainingsInstructing)
            //    .HasForeignKey(t => t.PTId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
