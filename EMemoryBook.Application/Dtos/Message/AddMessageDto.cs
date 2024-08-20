using System;
namespace EMemoryBook.Application.Dtos.Message
{
	public class AddMessageDto
	{
        public Guid EventId { get; set; }
        public string UserName { get; set; }
        public byte [] Content { get; set; }
    }
}

