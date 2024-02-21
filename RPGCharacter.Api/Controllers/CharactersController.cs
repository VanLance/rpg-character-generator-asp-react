using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGCharacter.Api.Data;
using RPGCharacter.Api.Models.Domain;
using RPGCharacter.Api.Models.DTO;

namespace RPGCharacter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly RpgCharacterDbContext dbContext;
        public CharactersController(RpgCharacterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var charactersDomain = dbContext.Characters.ToList();

            var charactersDto = new List<CharacterDto>();
            foreach (var character in charactersDomain)
            {
                charactersDto.Add(new CharacterDto()
                {
                    Id = character.Id,
                    Name = character.Name,
                    UserId = character.UserId,
                    ArchetypeId = character.ArchetypeId,
                    RaceId = character.RaceId,
                    StatsId = character.StatsId,
                });
            }
            return Ok(charactersDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var character = dbContext.Characters.Find(id);

            if (character == null)
            {
                return NotFound();
            }

            var characterDto = new CharacterDto()
            {
                Id = character.Id,
                Name = character.Name,
                Archetype = character.Archetype,
                Race = character.Race,
                UserId = character.UserId,
                //StatsId = character.StatsId,
            };
            return Ok(characterDto);
        }

        [HttpPost]
        public IActionResult PostCharacter([FromBody] PostCharacterRequestDto characterData)
        {
            var characterDomainModel = new Character
            {
                Name = characterData.Name,
                ArchetypeId = characterData.ArchetypeId,
                RaceId = characterData.RaceId,
                UserId = characterData.UserId,
            };
            dbContext.Characters.Add(characterDomainModel);
            dbContext.SaveChanges();

            var characterDto = new CharacterDto
            {
                Id = characterDomainModel.Id,
                Name = characterDomainModel.Name,
                ArchetypeId = characterDomainModel.ArchetypeId,
                RaceId = characterDomainModel.RaceId,
            };

            return CreatedAtAction(nameof(GetById), new { id = characterDomainModel.Id}, characterDomainModel );
        }
    }
}
