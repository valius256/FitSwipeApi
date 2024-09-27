using FitSwipe.DataAccess.EntityTypeCofiguration;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.SeedData;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.DataAccess.Model
{
    public class FitSwipeDbContext : DbContext
    {
        protected FitSwipeDbContext()
        {
        }

        public FitSwipeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTag> UserTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportImage> ReportImages { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserMedia> UserMedias { get; set; }
        public DbSet<FeedbackImage> FeedbackImages { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<SlotVideos> SlotVideos { get; set; }
        public DbSet<TransactionSlot> TransactionSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackImageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReportEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SlotEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TagEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserMediaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserTagEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReportImageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionSlotEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SlotVideoEntityTypeConfiguration());
            
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
