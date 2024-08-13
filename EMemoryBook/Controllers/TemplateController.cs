using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TemplateController : BaseController<Template>
{
    public TemplateController(BaseRepository<Template> repository) : base(repository)
    {
    }
}
