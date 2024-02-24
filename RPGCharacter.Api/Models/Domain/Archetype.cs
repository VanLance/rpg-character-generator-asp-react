namespace RPGCharacter.Api.Models.Domain
{
    public class Archetype
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }

        public ArchetypeKeyStats KeyStats { get; set; }
    }
}
