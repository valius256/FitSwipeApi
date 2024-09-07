using FitSwipe.DataAccess.EntityTypeCofiguration;
using FitSwipe.DataAccess.SeedData;
using FitSwipe.Shared.Model.User;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            

            modelBuilder.Seed();
        }
    }
}
