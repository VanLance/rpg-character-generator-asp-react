using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Services
{
    public class HealthPointsGenerator
    {
        readonly private Character character;
        public int Total;

        public HealthPointsGenerator(Character character)
        {
            this.character = character;
            UpdateHP();
        }
        private void UpdateHP()
        {
            int constitutionModifier = character.Stats.StatModifier(character.Stats.Constitution);
            Total = character.Archetype.HitDice + constitutionModifier;
        }
    }
}
