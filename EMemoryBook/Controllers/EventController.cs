using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : BaseController<Event>
    {
        public EventController(BaseRepository<Event> repository) : base(repository)
        {
        }
    }
}
