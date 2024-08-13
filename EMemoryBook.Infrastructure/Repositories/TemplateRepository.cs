using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure.Repositories;

public class TemplateRepository : BaseRepository<Template>, ITemplateRepository
{
    public TemplateRepository(EMemoryBookDbContext context) : base(context) { }

    public async Task<IEnumerable<Template>> GetPremiumTemplatesAsync()
    {
        return await _dbSet.Where(t => t.IsPremium).ToListAsync();
    }
}
