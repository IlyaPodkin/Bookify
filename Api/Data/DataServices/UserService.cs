using Api.Data.SettingsDb;
using Api.Models;
using Api.ModelsDTO;
using Microsoft.EntityFrameworkCore;
namespace Api.Data.DataServices
{
    public class UserService
    {
        private readonly ApplicationContext _context;
        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<User> Create(UserDTO userDTO)
        {
            var result = new User() { Name = userDTO.Name, Email=userDTO.Email,PhoneNumber = userDTO.PhoneNumber, Password = userDTO.Password};
            await _context.Users.AddAsync(result);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<List<User>> Get() => await _context.Users.ToListAsync();

        public async Task<bool> Update(Guid id, UserDTO userDTO)
        {
            var result = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (result == null)
            {
                return false;
            }
            result.Name = userDTO.Name;
            result.Email = userDTO.Email;
            result.PhoneNumber = userDTO.PhoneNumber;
            result.Password = userDTO.Password;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var result = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (result == null) 
            {
                return false;
            }
            _context.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
