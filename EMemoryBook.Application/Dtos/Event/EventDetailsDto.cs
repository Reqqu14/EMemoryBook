using System;
using EMemoryBook.Domain.Enums;

namespace EMemoryBook.Application.Dtos.Event
{
	public class EventDetailsDto
	{
        public EventType EventType { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string QrCode { get; set; }
        public string AccessPassword { get; set; }
        public PackageType PackageType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsPremium { get; set; }
    }
}

