using System;
using EMemoryBook.Application.Dtos.Event;
using EMemoryBook.Application.Dtos.Events;
using EMemoryBook.Domain.Models;

namespace EMemoryBook.Application.Interfaces;

public interface IEventService
{
    Task<IEnumerable<Event>> GetAll();
    Task<Event> GetById(Guid id);
    Task<IEnumerable<EventListDto>> GetByUserIdAsync(Guid userId);
    Task<EventDetailsDto> GetEventDetails(Guid eventId);
    Task DeleteEvent(Guid eventId);
    Task AddNewEvent(AddEventDto eventToAdd);
    Task UpdateEvent(UpdateEventDto eventToUpdate);
    Task<Guid> GetEventIdByPassword(string password);
}

