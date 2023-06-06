using System.ComponentModel.DataAnnotations;

namespace GardenApp.Mvc.Models
{
    public class UserLoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
