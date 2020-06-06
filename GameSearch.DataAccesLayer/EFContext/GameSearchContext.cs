using System.Diagnostics.CodeAnalysis;
using GameSearch.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameSearch.DataAccessLayer.EFContext
{
    public class GameSearchContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<RatingCharacteristic> RatingCharacteristics { get; set; }
        public DbSet<RatingField> RatingFields { get; set; }

        public GameSearchContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}