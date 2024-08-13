using EMemoryBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMemoryBook.Domain.Models;

public class Event
{
    public Guid Id { get; set; }
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


    public User User { get; set; }
    public Template Template { get; set; }
    public Payment Payment { get; set; }
    public ICollection<Message> Messages { get; set; }
}
