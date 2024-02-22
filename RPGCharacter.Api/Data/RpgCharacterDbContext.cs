using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RpgCharacterDbContext : DbContext
    {
        public RpgCharacterDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Archetype> Archetypes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Stats> Stats { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var races = new RaceDbData().RacesData;
            modelBuilder.Entity<Race>().HasData(races);

            var archetypes = new ArchetypeDbData().ArchetypesData;
            modelBuilder.Entity<Archetype>().HasData(archetypes);

            var raceStatBuffs = new RaceStatBuffDbData().RaceStatBuffsData; 
            modelBuilder.Entity<RaceStatBuff>().HasData(raceStatBuffs);

            var archetypeKeyStats = new ArchetypeKeyStatsDbData().ArchetypeKeyStatsData;
            modelBuilder.Entity<ArchetypeKeyStats>().HasData(archetypeKeyStats);
        }
    }
}
