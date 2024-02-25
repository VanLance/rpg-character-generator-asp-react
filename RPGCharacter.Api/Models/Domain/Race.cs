namespace RPGCharacter.Api.Models.Domain
{
    public class Race
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RaceStatBuffId { get; set; }


        public RaceStatBuff RaceStatBuff { get; set; }
    }
}
