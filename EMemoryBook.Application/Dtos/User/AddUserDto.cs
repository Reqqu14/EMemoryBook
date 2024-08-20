using System;
namespace EMemoryBook.Application.Dtos.User
{
	public class AddUserDto
	{
		public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
    }
}

