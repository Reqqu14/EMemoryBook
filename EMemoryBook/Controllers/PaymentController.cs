using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : BaseController<Payment>
{
    public PaymentController(BaseRepository<Payment> repository) : base(repository)
    {
    }
}
