using System.ComponentModel.DataAnnotations;

namespace Passwords.Models
{
    public class PasswordModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informar o nome do site/app")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Favor informar o E-mail!")]
        [EmailAddress(ErrorMessage = "O dado informado não é um E-mail valido! Favor informar E-mail valido!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha cadastrada!")]
        public string Senha { get; set; }
    }
}
