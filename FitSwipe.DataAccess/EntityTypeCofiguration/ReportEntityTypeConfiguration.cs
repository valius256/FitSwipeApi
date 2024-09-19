
using FitSwipe.DataAccess.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitSwipe.DataAccess.EntityTypeCofiguration
{
    public class ReportEntityTypeConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Reporter)
                .WithMany(x => x.ReportsCreated)
                .HasForeignKey(x => x.ReporterId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
