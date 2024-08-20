using EMemoryBook.Domain.Enums;
using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories;

public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task<Payment> GetByEventIdAsync(Guid eventId);
    Task SetPaymentStatus(Guid eventId, PaymentStatus paymentStatus);
}
