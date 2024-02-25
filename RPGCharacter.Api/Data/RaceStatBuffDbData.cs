using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RaceStatBuffDbData
    {
        public List<RaceStatBuff> RaceStatBuffsData;

        public RaceStatBuffDbData()
        {
            RaceStatBuffsData =
            [
                new RaceStatBuff()
                {
                    // elf
                    Id = Guid.Parse("6a379834-5bf8-4c85-8390-df01c9ea25b2"),
                    Stat = "Dexterity",
                    Buff = 2,
                },
                new RaceStatBuff()
                {
                    // hobbit
                    Id = Guid.Parse("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"),
                    Stat = "Dexterity",
                    Buff = 2,
                },
                new RaceStatBuff()
                {
                    // dwarf
                    Id = Guid.Parse("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"),
                    Stat = "Strength",
                    Buff = 2,
                },
            ];
        }
    }
}
