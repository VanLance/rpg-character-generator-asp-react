using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Services
{
    public class ArmorClassGenerator
    {
        public int Value { get; set; }
        readonly private Character character;
        public ArmorClassGenerator(Character character)
        {
            this.character = character;

            InitialAC();
        }

        // Create Getters and Settters

        private void InitialAC()
        {
            Value = 10 + character.Stats.StatModifier(character.Stats.Dexterity);
            character.Stats.ArmorClass = Value;
        }
    }
}
