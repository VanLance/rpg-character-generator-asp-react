using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RaceDbData
    {
        public List<Race> RacesData =
            [
                 new Race()
                 {
                     Id = Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                     Name = "Elf",
                     RaceStatBuffId = Guid.Parse("6a379834-5bf8-4c85-8390-df01c9ea25b2"),
                 },
                new Race()
                {
                    Id = Guid.Parse("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                    Name = "Dwarf",
                    RaceStatBuffId = Guid.Parse("ffdb0de9-74a4-4a16-acf8-80abf10c7e14"),
                },
                new Race()
                {
                    Id = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                    Name = "Hobbit",
                    RaceStatBuffId = Guid.Parse("a6f9cb9f-38e3-4a7c-b505-000ac7462c1e"),
                },
            ];
    }
}
