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
            AddRaceBuffs();
            Stats.HitPoints = new HealthPointsGenerator(character, Stats).Total;

            Stats.ArmorClass = new ArmorClassGenerator(character, Stats).Value;
            Console.WriteLine("Character stats");
        }

        public void UpdateKeyStats(ref int currentStatIndex)
        {
            var statFields = typeof(Stats).GetProperties();
            foreach (string keyStat in new List<string> { character.Archetype.KeyStats.KeyStat1, character.Archetype.KeyStats.KeyStat2 })
            {
                foreach (var statField in statFields)
                {
                    if (statField.Name.ToString() == keyStat.ToString())
                    {
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
                PropertyInfo propertyInfo = typeof(Stats).GetProperty(statTypeField.Name);
                ArrayList checks = new ArrayList { "HitPoints", "ArmorClass", "Id" };
                if (!checks.Contains(propertyInfo.Name.ToString()) && Convert.ToString(propertyInfo.GetValue(Stats)) == "0")
                {
                   
                    propertyInfo.SetValue(Stats, availableStats[currentStatIndex]);
                    currentStatIndex--;
                }
            }
        }

        private void AddRaceBuffs()
        {
            var stat = typeof(Stats).GetProperty(character.Race.RaceStatBuff.Stat );
            Console.WriteLine("before");
            Console.WriteLine(character.Race.RaceStatBuff.Stat);
            Console.WriteLine(stat);
            PropertyInfo propertyInfoUp = typeof(Stats).GetProperty("Dexterity");
            PropertyInfo propertyInfoLow = typeof(Stats).GetProperty("dexterity");
            Console.WriteLine("Up".Concat(propertyInfoUp.Name).ToString());
            if (stat != null)
            {
                Console.WriteLine("in if");
                stat.SetValue(Stats, (int)stat.GetValue(Stats)! + character.Race.RaceStatBuff.Buff);
            }
        }
    }
}
