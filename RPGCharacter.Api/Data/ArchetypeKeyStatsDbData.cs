using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class ArchetypeKeyStatsDbData
    {
        public List<ArchetypeKeyStats> ArchetypeKeyStatsData;

        public ArchetypeKeyStatsDbData()
        {
            ArchetypeKeyStatsData =
            [
                // barbarian
                new ArchetypeKeyStats()
                {
                    Id = Guid.Parse("d557739a-2903-4665-a2d1-000d9312ffb7"),
                    ArchetypeId = Guid.Parse("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                    KeyStat1 = "Strength",
                    KeyStat2 = "Dexterity",
                },
                // wizard
                new ArchetypeKeyStats()
                {
                    Id = Guid.Parse("8f8aaee5-a36f-4bc2-93d2-9758a376cd65"),
                    ArchetypeId = Guid.Parse("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                    KeyStat1 = "Intelligence",
                    KeyStat2 = "Wisdom",
                },
                // ranger
                new ArchetypeKeyStats()
                {
                    Id = Guid.Parse("50de78ff-fa9e-4024-980c-50ccead02e5c"),
                    ArchetypeId = Guid.Parse("9b4dd00d-0622-40e5-8331-bd894f362119"),
                    KeyStat1 = "Dexterity",
                    KeyStat2 = "Constitution",
                },

            ];
        }
    }
}
