using EntityFramework.Exceptions.SqlServer;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameSearch.DataAccessLayer.EFContext
{
    public sealed class GameSearchContext : DbContext
    {
        public GameSearchContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<StoreLink> StoreLinks { get; set; }
        public DbSet<RatingCharacteristic> RatingCharacteristics { get; set; }
        public DbSet<RatingField> RatingFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RatingField>()
                        .HasOne(p => p.RatingCharacteristic)
                        .WithMany(t => t.RatingFields)
                        .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseExceptionProcessor();
        }
    }
}