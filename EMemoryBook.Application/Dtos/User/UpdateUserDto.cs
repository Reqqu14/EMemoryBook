﻿using System;
namespace EMemoryBook.Application.Dtos.User
{
	public class UpdateUserDto
	{
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
    }
}

