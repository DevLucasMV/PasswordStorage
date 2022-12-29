using System.ComponentModel.DataAnnotations;

namespace Passwords.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Favor informar o login do usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Favor informar a senha do usuario")]
        public string Senha { get; set; }
    }
}
