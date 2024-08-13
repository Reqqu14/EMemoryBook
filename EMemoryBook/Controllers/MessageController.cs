using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : BaseController<Message>
{
    public MessageController(BaseRepository<Message> repository) : base(repository)
    {
    }
}
