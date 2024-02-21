namespace RPGCharacter.Api.Models.DTO
{
    public class StatsDto
    {
        public Guid Id { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
    }
}
