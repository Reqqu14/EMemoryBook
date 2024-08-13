using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure.Repositories;

public class MessageRepository : BaseRepository<Message>, IMessageRepository
{
    public MessageRepository(EMemoryBookDbContext context) : base(context) { }

    public async Task<IEnumerable<Message>> GetByEventIdAsync(Guid eventId)
    {
        return await _dbSet.Where(m => m.EventId == eventId).ToListAsync();
    }
}
