using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class UserRegisterModel
    {
        public string Username { get; set; }
        [DataType(DataType.Password)] // Annotation for form to understand
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
