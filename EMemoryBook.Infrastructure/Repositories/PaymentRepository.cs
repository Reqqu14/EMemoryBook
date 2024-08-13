using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure.Repositories;

public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(EMemoryBookDbContext context) : base(context) { }

    public async Task<Payment> GetByEventIdAsync(Guid eventId)
    {
        return await _dbSet.FirstOrDefaultAsync(p => p.EventId == eventId);
    }
}
