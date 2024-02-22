using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Repositories
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetAllAsync();
        Task<Character> GetByIdAsync();
    }
}
