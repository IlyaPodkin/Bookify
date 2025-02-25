using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^\+?[0-9\s-]+$", ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
