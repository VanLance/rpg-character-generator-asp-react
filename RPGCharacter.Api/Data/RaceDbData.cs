using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class RaceDbData
    {
        public List<Race> RacesData = new List<Race>()
        {
             new Race()
            {
                Id = Guid.Parse("65728c3a-78c6-4a46-a79e-393843c2c098"),
                Name = "elf",
            },
            new Race()
            {
                Id = Guid.Parse("6d549445-d419-4a35-9ecb-84567e4b03ff"),
                Name = "dwarf",
            },
            new Race()
            {
                Id = Guid.Parse("d17528a7-34d8-4abc-93b2-d01787e44fad"),
                Name = "hobbit",
            },
        };
    }
}
