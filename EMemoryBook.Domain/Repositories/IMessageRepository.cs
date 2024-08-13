using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories
{
    public interface IMessageRepository : IBaseRepository<Message>
    {
        Task<IEnumerable<Message>> GetByEventIdAsync(Guid eventId);
    }
}
