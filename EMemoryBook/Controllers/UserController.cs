using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(BaseRepository<User> repository) : base(repository)
        {
        }
    }
}
