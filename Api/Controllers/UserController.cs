using Api.Data.DataServices;
using Api.Data.SettingsDb;
using Api.Models;
using Api.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserService _service;
        public UserController(UserService service) 
        {
            _service = service;
        }

        [HttpPost("user")]
        public async Task<IActionResult> CreateUser(UserDTO userDTO) 
        {
            if (string.IsNullOrWhiteSpace(userDTO.Name) ||
                string.IsNullOrWhiteSpace(userDTO.Email) ||
                string.IsNullOrWhiteSpace(userDTO.PhoneNumber) ||
                string.IsNullOrWhiteSpace(userDTO.Password))
            {
                return BadRequest("Необходимо заполнить все обязательные поля");

            }
            var result = await _service.Create(userDTO);
            return Ok(result);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers() => Ok(await _service.Get());

        [HttpPut("user")]
        public async Task<IActionResult> UpdateUser(Guid id, UserDTO userDTO) 
        {
            if (string.IsNullOrWhiteSpace(userDTO.Name) ||
                string.IsNullOrWhiteSpace(userDTO.Email) ||
                string.IsNullOrWhiteSpace(userDTO.PhoneNumber) ||
                string.IsNullOrWhiteSpace(userDTO.Password))
            {
                return BadRequest("Поля не должны быть пустыми");

            }
            var result = await _service.Update(id, userDTO);
            if (!result)
            {
                return BadRequest("Пользователь не найден");
            }
            return Ok(result);
        }

        [HttpDelete("user")]
        public async Task<IActionResult> DeleteUser(Guid id) 
        {
            var result = await _service.Delete(id);
            if (!result)
            {
                return BadRequest("Пользователь не найден");
            }
            return Ok(result);
        }

    }
}
