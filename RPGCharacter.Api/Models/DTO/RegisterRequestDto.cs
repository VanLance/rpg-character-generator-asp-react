using System.ComponentModel.DataAnnotations;

namespace RPGCharacter.Api.Models.DTO
{
    public class RegisterRequestDto
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
    }
}
