using EMemoryBook.Application.Dtos.Event;
using EMemoryBook.Application.Dtos.Events;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IEnumerable<Event>> GetAll()
        {
            var events = await _eventService.GetAll();
            return events;
        }

        [HttpGet("/eventId")]
        public async Task<Guid> GetEventIdByPassword(string password)
        {
            return await _eventService.GetEventIdByPassword(password);
        }

        [HttpGet("/userId")]
        public async Task<IEnumerable<EventListDto>> GetByUserId(Guid userId)
        {
            var events = await _eventService.GetByUserIdAsync(userId);
            return events;
        }

        [HttpGet("/details")]
        public async Task<EventDetailsDto> GetEventDetails(Guid eventId)
        {
            var eventDetails = await _eventService.GetEventDetails(eventId);
            return eventDetails;
        }

        [HttpGet("/all")]
        public async Task<Event> GetById(Guid eventId)
        {
            var @event = await _eventService.GetById(eventId);
            return @event;
        }

        [HttpPost]
        public async Task AddEvent([FromBody] AddEventDto eventToAdd)
        {
            await _eventService.AddNewEvent(eventToAdd);
        }

        [HttpPut]
        public async Task UpdateEvent([FromBody] UpdateEventDto eventToUpdate)
        {
            await _eventService.UpdateEvent(eventToUpdate);
        }

        [HttpDelete]
        public async Task DeleteEvent(Guid eventId)
        {
            await _eventService.DeleteEvent(eventId);
        }

    }
}
