using Microsoft.EntityFrameworkCore;
using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RpgCharacterDbContext : DbContext
    {
        public RpgCharacterDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; } 
        public DbSet<Archetype> Archetypes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Stats> Stats { get; set; }
    }
}
