

using System;
using EMemoryBook.Application.Dtos.User;
using EMemoryBook.Domain.Models;

namespace EMemoryBook.Application.Interfaces
{
	public interface IUserService
	{
		Task<User> GetById(Guid id);
		Task<User> GetByEmail(string email);
		Task AddUser(AddUserDto user);
		Task UpadteUser(UpdateUserDto user);
		Task DeleteUserById(Guid id);
	}
}

