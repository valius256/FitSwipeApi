
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasOne(ut => ut.CreateBy)
                .WithMany(u => u.TagsCreated)
                .HasForeignKey(ut => ut.CreateById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
