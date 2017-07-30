using Battle4Beers.Data.Migrations;
using Battle4Beers.Models;

namespace Battle4Beers.Data
{

    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Battle4BeersDbContext : DbContext
    {
        public Battle4BeersDbContext()
            : base("name=Battle4BeersDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Battle4BeersDbContext, Configuration>());
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(p => p.BeersToBeTaken)
                .WithRequired(b => b.Winner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(p => p.BeersToBeGiven)
                .WithRequired(b => b.Loser)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

    }
}