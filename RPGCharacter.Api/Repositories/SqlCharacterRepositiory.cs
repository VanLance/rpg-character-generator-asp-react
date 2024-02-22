using Microsoft.EntityFrameworkCore;
using RPGCharacter.Api.Data;
using RPGCharacter.Api.Models.Domain;

namespace RPGCharacter.Api.Repositories
{
    public class SqlCharacterRepositiory : ICharacterRepository
    {
        private readonly RpgCharacterDbContext dbContext;

        public SqlCharacterRepositiory(RpgCharacterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Character>> GetAllAsync()
        {
            return await dbContext.Characters.ToListAsync();
        }

        public Task<Character> GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
