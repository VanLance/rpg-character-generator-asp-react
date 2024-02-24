using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Services
{
    public class HealthPointsGenerator
    {
        readonly private Character character;
        readonly private Stats Stats;
        public int Total;

        public HealthPointsGenerator(Character character, Stats stats)
        {
            this.Stats = stats;
            this.character = character;
            UpdateHP();
        }
        private void UpdateHP()
        {
            int constitutionModifier = Stats.StatModifier(Stats.Constitution);
            Total = character.Archetype.HitDice + constitutionModifier;
        }
    }
}
