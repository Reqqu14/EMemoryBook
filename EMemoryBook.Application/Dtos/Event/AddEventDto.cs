using System;
using EMemoryBook.Domain.Enums;

namespace EMemoryBook.Application.Dtos.Events
{
	public class AddEventDto
	{
        public Guid UserId { get; set; }
        public EventType EventType { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public Guid TemplateId { get; set; }
        public string QrCode { get; set; }
        public string AccessPassword { get; set; }
        public PackageType PackageType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

