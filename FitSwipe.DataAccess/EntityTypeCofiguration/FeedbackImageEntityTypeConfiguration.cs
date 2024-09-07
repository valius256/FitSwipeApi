
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class FeedbackImageEntityTypeConfiguration : IEntityTypeConfiguration<FeedbackImage>
    {
        public void Configure(EntityTypeBuilder<FeedbackImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Training)
                .WithMany(x => x.FeedbackImages)
                .HasForeignKey(x => x.TrainingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
