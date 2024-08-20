using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(EMemoryBookDbContext context) : base(context) { }

        public async Task<IEnumerable<Event>> GetByUserIdAsync(Guid userId)
        {
            return await _dbSet.Where(e => e.UserId == userId).ToListAsync();
        }

        public async Task<Guid> GetEventIdByPassword(string password)
        {
            var @event = await _dbSet.FirstOrDefaultAsync(x => x.AccessPassword == password);
            return @event.Id;
        }

        public async Task<Event> GetEventWithDetailsAsync(Guid eventId)
        {
            return await _dbSet
                .Include(e => e.Template)
                .Include(e => e.Messages)
                .Include(e => e.Payment)
                .FirstOrDefaultAsync(e => e.Id == eventId);
        }
    }
}
