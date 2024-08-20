using System;
using EMemoryBook.Domain.Enums;

namespace EMemoryBook.Application.Interfaces
{
	public interface IPaymentService
	{
		Task SetPaymentStatus(Guid eventId, PaymentStatus paymentStatus);
	}
}

