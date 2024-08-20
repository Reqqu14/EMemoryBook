using System;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EMemoryBook.Application.Dtos.Message;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;
using Microsoft.Extensions.Configuration;

namespace EMemoryBook.Application.Services
{
    public class MessageService : IMessageService
	{
        private readonly IMessageRepository _messageRepository;
        private readonly string _connectionString;

        public MessageService(IMessageRepository messageRepository, IConfiguration configuration)
		{
            _messageRepository = messageRepository;
            _connectionString = configuration["BlobStorageCS"];
        }

        public async Task AddMessage(AddMessageDto messageToAdd)
        {
            BlobContainerClient containerClient = new BlobContainerClient(_connectionString, messageToAdd.EventId.ToString());
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

            string blobName = $"{messageToAdd.EventId}/{messageToAdd.UserName}/{DateTime.Now}";
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            using (var memoryStream = new MemoryStream(messageToAdd.Content))
            {
                await blobClient.UploadAsync(memoryStream, new BlobHttpHeaders { ContentType = "image/jpeg" });
            }

            var uri = blobClient.Uri.ToString();

            var message = new Message{ EventId = messageToAdd.EventId, UserName = messageToAdd.UserName, Content ="123", MediaUrl = uri, CreatedAt = DateTime.Now};
            await _messageRepository.AddAsync(message);
        }

        public async Task<IEnumerable<MessageDetailsDto>> GetMessagesForEvent(Guid eventId)
        {
            var messages = await _messageRepository.GetByEventIdAsync(eventId);
            return messages.Select(x => new MessageDetailsDto { MediaUrl = x.MediaUrl, UserName = x.UserName }).ToList();
        }
    }
}

