using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPatch]
    public async Task SetPaymentStatus(Guid eventId, PaymentStatus paymentStatus)
    {
        await _paymentService.SetPaymentStatus(eventId, paymentStatus);
    }
}
