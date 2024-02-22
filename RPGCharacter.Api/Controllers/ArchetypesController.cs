using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPGCharacter.Api.Data;

namespace RPGCharacter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchetypesController : ControllerBase
    {
        private readonly RpgCharacterDbContext dbContext;

        public ArchetypesController(RpgCharacterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var archetype = dbContext.Archetypes.Find(id);

            if( archetype == null)
            {
                return NotFound();
            }

            return Ok(archetype);
        }
    }
}
