using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Username = "FooBar",
                    Email = "foo@bar.com"
                }
            };
            return Ok("foo users");
            //public IActionResult  
        }
    }
}
