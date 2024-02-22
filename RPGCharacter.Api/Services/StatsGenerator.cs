using RPGCharacter.Api.Models.Domain;
using System.Reflection;

namespace RPGCharacter.Api.Services
{
    public class StatsGenerator
    {
        public Character character;
        int[] availableStats = new StatRoller().stats;

        public StatsGenerator(Character character)
        {
            this.character = character;
            this.character.Stats = new Stats();

            int currentStatIndex = availableStats.Length - 1;

            Array.Sort(availableStats);

            UpdateKeyStats(ref currentStatIndex);
            UpdateRemainingStats(ref currentStatIndex);
            character.Stats.HitPoints = new HealthPointsGenerator(character).Total;

            character.Stats.ArmorClass =  new ArmorClassGenerator(character).Value;
        }

        public void UpdateKeyStats(ref int currentStatIndex)
        {
            Console.WriteLine(character.Name);

            FieldInfo[] statFields = typeof(Stats).GetFields();
            foreach (StatType keyStat in character.Archetype.keyStats)
            {
                foreach (FieldInfo statField in statFields)
                {
                    if (statField.Name == keyStat.ToString())
                    {
                        statField.SetValue(character.Stats, availableStats[currentStatIndex]);
                    }
                }
                currentStatIndex--;
            }
        }

        private void UpdateRemainingStats(ref int currentStatIndex)
        {
            FieldInfo[] fields = typeof(StatType).GetFields();
            foreach (FieldInfo statTypeField in fields)
            {
                Console.WriteLine(statTypeField.Name);
                FieldInfo fieldInfo = typeof(Stats).GetField(statTypeField.Name);
                if (fieldInfo != null && Convert.ToString(fieldInfo.GetValue(character.Stats)) == "0")
                {
                    fieldInfo.SetValue(character.Stats, availableStats[currentStatIndex]);
                    currentStatIndex--;
                }
            }
        }
    }
    public enum StatType
    {
        Strength,
        Dexterity,
        Constitution,
        Wisdom,
        Intelligence,
        Charisma
    }
}
