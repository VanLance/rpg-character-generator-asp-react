using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RaceStatBuffDbData
    {
        public List<RaceStatBuff> RaceStatBuffsData;

        public RaceStatBuffDbData()
        {
            RaceStatBuffsData = new List<RaceStatBuff>()
            {
                new RaceStatBuff()
                {
                    // elf
                    Id = Guid.Parse("6a379834-5bf8-4c85-8390-df01c9ea25b2"),
                    Stat = "dexterity",
                    RaceId = Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                    Buff = 2,
                },
                new RaceStatBuff()
                {
                    // hobbit
                    Id = Guid.Parse("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"),
                    Stat = "dexterity",
                    RaceId = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                    Buff = 2,
                },
                new RaceStatBuff()
                {
                    // dwarf
                    Id = Guid.Parse("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"),
                    Stat = "strength",
                    RaceId = Guid.Parse("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                    Buff = 2,
                },
            };
        }
    }
}
