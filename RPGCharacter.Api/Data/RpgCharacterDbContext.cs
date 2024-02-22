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

            var races = new List<Race>()
            {
                new Race()
                {
                    Id = Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                    Name = "elf",
                },
                 new Race()
                {
                    Id = Guid.Parse("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                    Name = "dwarf",
                },
                new Race()
                {
                    Id = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                    Name = "hobbit",
                },
            };
            modelBuilder.Entity<Race>().HasData(races);

            var archetypes = new List<Archetype>()
            {
                new Archetype()
                {
                    Id = Guid.Parse("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                    Name = "barbarian",
                    HitDice = 10,
                },
                 new Archetype()
                {
                    Id = Guid.Parse("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                    Name = "wizard",
                    HitDice = 8,
                },
                new Archetype()
                {
                    Id = Guid.Parse("9b4dd00d-0622-40e5-8331-bd894f362119"),
                    Name = "rogue",
                    HitDice = 10,
                },
            };
            modelBuilder.Entity<Archetype>().HasData(archetypes);

            var raceStatBuffs = new List<RaceStatBuff>()
            {
                new RaceStatBuff()
                {
                    //elf
                    Id =  Guid.Parse(""),
                    Stat = ,
                    RaceId =  Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                    Buff = ,
                },
                new RaceStatBuff()
                {
                    // elf
                    Id = Guid.Parse(""),
                    Stat = ,
                    RaceId = Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                    Buff = ,
                },
                new RaceStatBuff()
                {
                    // hobbit
                    Id = Guid.Parse(""),
                    Stat = ,
                    RaceId = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                    Buff = ,
                },
                new RaceStatBuff()
                {
                    // hobbit
                    Id = Guid.Parse(""),
                    Stat = ,
                    RaceId = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                    Buff = ,
                },
                new RaceStatBuff()
                {
                    // dwarf
                    Id = Guid.Parse(""),
                    Stat = ,
                    RaceId = ,
                    Buff = ,
                },
                new RaceStatBuff()
                {
                    // dwarf
                    Id = Guid.Parse(""),
                    Stat = ,
                    RaceId = ,
                    Buff = ,
                },
            }
        }
    }
}
