using EMemoryBook.Application.Dtos.Message;
using EMemoryBook.Application.Dtos.Template;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageService _messageService;

    public MessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    [HttpGet]
    public async Task<IEnumerable<MessageDetailsDto>> GetMessagesForEvent(Guid eventId)
    {
        var messages = await _messageService.GetMessagesForEvent(eventId);
        return messages;
    }

    [HttpPost]
    public async Task AddMessage(Guid eventId, string userName, IFormFile file)
    {
        byte[] fileBytes;
        using (var memoryStream = new MemoryStream())
        {
            await file.CopyToAsync(memoryStream);
            fileBytes = memoryStream.ToArray();
        }

        await _messageService.AddMessage(new AddMessageDto { Content = fileBytes, UserName = userName, EventId = eventId});
    }
}
