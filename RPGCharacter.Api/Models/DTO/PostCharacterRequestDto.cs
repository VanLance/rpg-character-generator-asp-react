using System.ComponentModel.DataAnnotations;

namespace RPGCharacter.Api.Models.DTO
{
    public class PostCharacterRequestDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid RaceId { get; set; }
        [Required]
        public Guid ArchetypeId { get; set; }
        [Required]
        public Guid StatsId { get; set; }
    }
}
