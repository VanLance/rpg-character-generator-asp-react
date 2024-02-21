using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Models.DTO
{
    public class CharacterDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RaceId { get; set; }
        public Guid ArchetypeId { get; set; }
        public Guid StatsId { get; set; }
        public Guid UserId { get; set; }

        public RaceDto Race { get; set; }
        public ArchetypeDto Archetype { get; set; }
        public StatsDto Stats { get; set; }
        public User User { get; set; }
    }
}
