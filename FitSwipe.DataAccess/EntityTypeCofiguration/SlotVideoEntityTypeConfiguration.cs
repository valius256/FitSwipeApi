using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration;

public class SlotVideoEntityTypeConfiguration : IEntityTypeConfiguration<SlotVideos>
{
    public void Configure(EntityTypeBuilder<SlotVideos> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(x => x.Slot).WithMany(x => x.Videos).OnDelete(DeleteBehavior.Restrict);
    }
}