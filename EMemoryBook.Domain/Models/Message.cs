using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMemoryBook.Domain.Models;

public class Message
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }
    public string UserName { get; set; }
    public string Content { get; set; }
    public string MediaUrl { get; set; }
    public DateTime CreatedAt { get; set; }


    public Event Event { get; set; }
}
