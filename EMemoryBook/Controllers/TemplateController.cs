using EMemoryBook.Application.Dtos.Template;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TemplateController : ControllerBase
{
    private readonly ITemplateService _templateService;

    public TemplateController(ITemplateService templateService)
    {
        _templateService = templateService;
    }

    [HttpGet]
    public async Task<IEnumerable<TemplatesListDto>> GetAll()
    {
        var templates = await _templateService.GetTemplates();
        return templates;
    }
}
