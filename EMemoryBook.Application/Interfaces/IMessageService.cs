using System;
using EMemoryBook.Application.Dtos.Message;

namespace EMemoryBook.Application.Interfaces
{
	public interface IMessageService
	{
		Task<IEnumerable<MessageDetailsDto>> GetMessagesForEvent(Guid eventId);
		Task AddMessage(AddMessageDto messageToAdd);
	}
}

