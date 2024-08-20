using System;
using EMemoryBook.Application.Dtos.User;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Domain.Repositories;

namespace EMemoryBook.Application.Services
{
    public class UserService : IUserService
	{
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
		{
            _userRepository = userRepository;
        }

        public async Task AddUser(AddUserDto user)
        {
            var userToAdd = new User{ Email = user.Email, PasswordHash= user.PasswordHash, FullName = user.FullName};

            await _userRepository.AddAsync(userToAdd);
        }

        public async Task DeleteUserById(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<User> GetById(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task UpadteUser(UpdateUserDto user)
        {
            var existingUser = await _userRepository.GetByIdAsync(user.Id);
            await _userRepository.UpdateAsync(existingUser);
        }
    }
}

