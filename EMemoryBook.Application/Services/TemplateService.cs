using EMemoryBook.Application.Dtos.Template;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Repositories;

namespace EMemoryBook.Application.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _templateRepository;

        public TemplateService(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }
        public async Task<IEnumerable<TemplatesListDto>> GetTemplates()
        {
            var templates = await _templateRepository.GetAllAsync();
            return new List<TemplatesListDto>(); 
        }
    }
}

