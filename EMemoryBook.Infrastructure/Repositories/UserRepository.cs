using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(EMemoryBookDbContext context) : base(context) { }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
