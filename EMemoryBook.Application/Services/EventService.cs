using EMemoryBook.Application.Dtos.Event;
using EMemoryBook.Application.Dtos.Events;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using EMemoryBook.Infrastructure;
using EMemoryBook.Infrastructure.Repositories;

namespace EMemoryBook.Application.Services;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;

    public EventService(IEventRepository eventRepository)
	{
        _eventRepository = eventRepository;
    }

    public async Task AddNewEvent(AddEventDto eventToAdd)
    {
        var @event = new Event{ UserId = eventToAdd.UserId, EventType = eventToAdd.EventType, EventName = eventToAdd.EventName, Date = eventToAdd.Date, Location = eventToAdd.Location,
            TemplateId = eventToAdd.TemplateId, AccessPassword = eventToAdd.AccessPassword, QrCode = eventToAdd.QrCode, PackageType = eventToAdd.PackageType, CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now};
        await _eventRepository.AddAsync(@event);
    }

    public async Task DeleteEvent(Guid eventId)
    {
        await _eventRepository.DeleteAsync(eventId);
    }

    public async Task<IEnumerable<Event>> GetAll()
    {
        return await _eventRepository.GetAllAsync();
    }

    public async Task<Event> GetById(Guid id)
    {
        return await _eventRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<EventListDto>> GetByUserIdAsync(Guid userId)
    {
        var @event = await _eventRepository.GetByUserIdAsync(userId);
        //zrobic mapowanie
        return new List<EventListDto>();
    }

    public async Task<EventDetailsDto> GetEventDetails(Guid eventId)
    {
        var eventDetails = await _eventRepository.GetEventWithDetailsAsync(eventId);
        return new EventDetailsDto();
    }

    public async Task<Guid> GetEventIdByPassword(string password)
    {
        return await _eventRepository.GetEventIdByPassword(password);
    }

    public async Task UpdateEvent(UpdateEventDto eventToUpdate)
    {
        var @event = new Event();
        await _eventRepository.UpdateAsync(@event);
    }
}

