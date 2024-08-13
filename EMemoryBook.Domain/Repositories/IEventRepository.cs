using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories;

public interface IEventRepository : IBaseRepository<Event>
{
    Task<IEnumerable<Event>> GetByUserIdAsync(Guid userId);
    Task<Event> GetEventWithDetailsAsync(Guid eventId);
}
