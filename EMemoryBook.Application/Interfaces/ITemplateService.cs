using System;
using EMemoryBook.Application.Dtos.Template;

namespace EMemoryBook.Application.Interfaces
{
	public interface ITemplateService
	{
		Task<IEnumerable<TemplatesListDto>> GetTemplates();
	}
}

