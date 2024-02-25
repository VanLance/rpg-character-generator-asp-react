using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGCharacter.Api.Data;
using RPGCharacter.Api.Models.Domain;
using RPGCharacter.Api.Models.DTO;
using RPGCharacter.Api.Repositories;
using RPGCharacter.Api.Services;

namespace RPGCharacter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly RpgCharacterDbContext dbContext;
        private readonly ICharacterRepository characterRepository;

        public CharactersController(RpgCharacterDbContext dbContext, ICharacterRepository characterRepository)
        {
            this.dbContext = dbContext;
            this.characterRepository = characterRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var charactersDomain = await characterRepository.GetAllAsync();
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
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var character = await dbContext.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            var characterDto = new CharacterDto()
            {
                Id = character.Id,
                Name = character.Name,
                ArchetypeId = character.ArchetypeId,
                RaceId = character.RaceId,
                UserId = character.UserId,
                StatsId = character.StatsId,
            };
            return Ok(characterDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostCharacter([FromBody] PostCharacterRequestDto characterData)
        {
            var characterDomainModel = new Character
            {
                Name = characterData.Name,
                ArchetypeId = characterData.ArchetypeId,
                RaceId = characterData.RaceId,
                UserId = characterData.UserId,

            };

            // Fetch the corresponding archetype object from the database
            var archetype = dbContext.Archetypes
                .Include(a => a.KeyStats)
                .FirstOrDefault(a => a.Id == characterData.ArchetypeId);

            var race = dbContext.Races.Include("RaceStatBuff").FirstOrDefault(race => race.Id == characterData.RaceId);

            // Assign the fetched archetype to the character's Archetype property
            characterDomainModel.Archetype = archetype;
            characterDomainModel.Race = race;
            characterDomainModel.Stats =  new StatsGenerator(characterDomainModel).Stats;

            await dbContext.Characters.AddAsync(characterDomainModel);
            await dbContext.SaveChangesAsync();

            var characterDto = new CharacterDto
            {
                Id = characterDomainModel.Id,
                Name = characterDomainModel.Name,
                ArchetypeId = characterDomainModel.ArchetypeId,
                RaceId = characterDomainModel.RaceId,
            };

            return CreatedAtAction(nameof(GetById), new { id = characterDomainModel.Id }, characterDomainModel);
        }
    }
}
