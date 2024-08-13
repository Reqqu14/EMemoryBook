using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories;

public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task<Payment> GetByEventIdAsync(Guid eventId);
}
