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
            var result = await _service.Create(userDTO);
            if (result == null) 
            {
                return BadRequest("Не удалось создать пользователя");
            }
            return Ok(result);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers() => Ok(await _service.Get());

        [HttpPut("user")]
        public async Task<IActionResult> UpdateUser(Guid id, UserDTO userDTO) 
        {
            var result = await _service.Update(id, userDTO);
            if (!result) 
            {
                return BadRequest("Изменения не были применены");
            }
            return Ok(result);
        }

        [HttpDelete("user")]
        public async Task<IActionResult> DeleteUser(Guid id) 
        {
            var result = await _service.Delete(id);
            if (!result) 
            {
                return BadRequest("Не удалось удалить пользователя.");
            }
            return Ok(result);
        }

    }
}
