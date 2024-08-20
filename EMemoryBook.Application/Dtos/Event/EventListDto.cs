using System;
using EMemoryBook.Domain.Enums;

namespace EMemoryBook.Application.Dtos.Event
{
	public class EventListDto
	{
        public EventType EventType { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string QrCode { get; set; }
        public string AccessPassword { get; set; }
        public PackageType PackageType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

