using System;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Enums;
using EMemoryBook.Domain.Repositories;

namespace EMemoryBook.Application.Services
{
    public class PaymentService : IPaymentService
	{
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
		{
            _paymentRepository = paymentRepository;
        }

        public async Task SetPaymentStatus(Guid eventId, PaymentStatus paymentStatus)
        {
            await _paymentRepository.SetPaymentStatus(eventId, paymentStatus);
        }
    }
}

