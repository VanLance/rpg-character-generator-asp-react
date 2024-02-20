namespace RPGCharacter.Api.Models.Domain
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public Guid RaceId { get; set; }
        public Guid ArchetypeId { get; set; }
        public Guid StatsId { get; set; }

        public User User { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }

    }
}
