using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Data
{
    public class ArchetypeDbData
    {
        public List<Archetype> ArchetypesData = new List<Archetype>()
        {
            new Archetype()
            {
                Id = Guid.Parse("60d2434d-74ad-42a3-9664-dbfe796a4c5b"),
                Name = "barbarian",
                HitDice = 10,
            },
            new Archetype()
            {
                Id = Guid.Parse("6a2c8fc7-3773-4569-9a3e-cf4d5b5a68f3"),
                Name = "wizard",
                HitDice = 8,
            },
            new Archetype()
            {
                Id = Guid.Parse("9b4dd00d-0622-40e5-8331-bd894f362119"),
                Name = "ranger",
                HitDice = 10,
            },
        };
    }
}
