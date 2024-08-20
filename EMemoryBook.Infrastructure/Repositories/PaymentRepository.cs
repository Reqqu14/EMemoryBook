using EMemoryBook.Domain.Enums;
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

    public async Task SetPaymentStatus(Guid eventId, PaymentStatus paymentStatus)
    {
        var payment = await _dbSet.FirstOrDefaultAsync(x => x.EventId == eventId) ?? throw new Exception("Payment for event not exists.");
        payment.Status = paymentStatus;
        _dbSet.Update(payment);
        await _context.SaveChangesAsync();
    }
}
