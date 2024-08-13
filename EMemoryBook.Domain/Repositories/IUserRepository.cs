using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmailAsync(string email);
}
