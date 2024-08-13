using EMemoryBook.Domain.Enums;

namespace EMemoryBook.Domain.Models;

public class Payment
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid EventId { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }

    public User User { get; set; }
    public Event Event { get; set; }
}
