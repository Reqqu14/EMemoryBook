using EMemoryBook.Domain.Models;

namespace EMemoryBook.Domain.Repositories;

public interface ITemplateRepository : IBaseRepository<Template>
{
    Task<IEnumerable<Template>> GetPremiumTemplatesAsync();
}
