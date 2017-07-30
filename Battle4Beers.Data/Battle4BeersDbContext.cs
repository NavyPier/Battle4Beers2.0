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
        public virtual DbSet<SingleScore> SingleScores { get; set; }
        public virtual DbSet<TeamScore> TeamScores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SingleScore>()
                .HasRequired(s => s.Player)
                .WithMany(p => p.SingleScores)
                .WillCascadeOnDelete(false);
            
            base.OnModelCreating(modelBuilder);
        }

    }
}