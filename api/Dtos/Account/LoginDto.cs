using System.ComponentModel.DataAnnotations;

namespace api.Controllers
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}