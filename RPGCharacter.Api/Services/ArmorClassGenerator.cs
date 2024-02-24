using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Services
{
    public class ArmorClassGenerator
    {
        public int Value { get; set; }
        readonly private Character character;
        readonly private Stats Stats;

        public ArmorClassGenerator(Character character, Stats Stats)
        {
            this.Stats = Stats;
            this.character = character;
            
            InitialAC();
        }

        // Create Getters and Settters

        private void InitialAC()
        {
            Value = 10 + Stats.StatModifier(Stats.Dexterity);
        }
    }
}
