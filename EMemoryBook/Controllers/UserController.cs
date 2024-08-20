using EMemoryBook.Application.Dtos.User;
using EMemoryBook.Application.Interfaces;
using EMemoryBook.Domain.Models;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<User> GetById(Guid userId)
        {
            var user = await _userService.GetById(userId);
            return user;
        }

        [HttpGet("/email")]
        public async Task<User> GetByEmail(string email)
        {
            var user = await _userService.GetByEmail(email);
            return user;
        }

        [HttpPost]
        public async Task Add([FromBody] AddUserDto user)
        {
            await _userService.AddUser(user);
        }

        [HttpPut]
        public async Task Update([FromBody] UpdateUserDto user)
        {
            await _userService.UpadteUser(user);
        }

        [HttpDelete]
        public async Task Delete(Guid userId)
        {
            await _userService.DeleteUserById(userId);
        }
    }
}
