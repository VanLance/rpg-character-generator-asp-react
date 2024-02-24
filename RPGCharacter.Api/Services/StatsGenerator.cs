using RPGCharacter.Api.Models.Domain;
using System.Collections;
using System.Reflection;

namespace RPGCharacter.Api.Services
{
    public class StatsGenerator
    {
        public Character character;
        int[] availableStats = new StatRoller().stats;
        public Stats Stats;

        public StatsGenerator(Character character)
        {
            this.character = character;
            Stats = new Stats();

            int currentStatIndex = availableStats.Length - 1;

            Array.Sort(availableStats);
            Console.WriteLine("available");
            Console.WriteLine(availableStats.ToString());

            UpdateKeyStats(ref currentStatIndex);
            UpdateRemainingStats(ref currentStatIndex);
            Stats.HitPoints = new HealthPointsGenerator(character, Stats).Total;

            Stats.ArmorClass = new ArmorClassGenerator(character, Stats).Value;
            Console.WriteLine("Character stats");
        }

        public void UpdateKeyStats(ref int currentStatIndex)
        {
            var statFields = typeof(Stats).GetProperties();
            foreach (string keyStat in new List<string> { character.Archetype.KeyStats.KeyStat1,character.Archetype.KeyStats.KeyStat2 } )
            {
                foreach (var statField in statFields)
                {
                    if (statField.Name.ToString().ToLower() == keyStat.ToString())
                    {
                        Console.WriteLine("WE GOTTA MATCDH");
                        Console.WriteLine(statField.ToString());
                        statField.SetValue(Stats, availableStats[currentStatIndex]);
                    }
                }
                currentStatIndex--;
            }
        }

        private void UpdateRemainingStats(ref int currentStatIndex)
        {
            PropertyInfo[] fields = typeof(Stats).GetProperties();
            foreach (PropertyInfo statTypeField in fields)
            {
                Console.WriteLine(statTypeField.ToString());
                PropertyInfo propertyInfo = typeof(Stats).GetProperty(statTypeField.Name);
                ArrayList checks = new ArrayList{ "HitPoints", "ArmorClass", "Id" };
                if (!checks.Contains(propertyInfo.Name.ToString()) && Convert.ToString(propertyInfo.GetValue(Stats)) == "0")
                {
                    Console.WriteLine("change");
                    Console.WriteLine(propertyInfo);
                    propertyInfo.SetValue(Stats, availableStats[currentStatIndex]);
                    currentStatIndex--;
                }
            }
        }
    }
}
