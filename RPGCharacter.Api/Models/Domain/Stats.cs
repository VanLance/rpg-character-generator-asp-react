namespace RPGCharacter.Api.Models.Domain
{
    public class Stats
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

        public int StatModifier(int statValue)
        {
            if (statValue >= 10)
            {
                return (statValue - 10) / 2;
            }
            return (statValue - 11) / 2;
        }
    }
}
