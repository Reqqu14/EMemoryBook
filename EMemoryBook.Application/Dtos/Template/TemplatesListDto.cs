using System;
namespace EMemoryBook.Application.Dtos.Template
{
	public class TemplatesListDto
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPremium { get; set; }
    }
}

