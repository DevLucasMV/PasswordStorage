using Passwords.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Passwords.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor informar o nome do usuario")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Favor informar o login do usuario")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Favor informar o email do usuario")]
        [EmailAddress(ErrorMessage = "O dado informado não é um E-mail valido! Favor informar E-mail valido!")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Favor selecionar o perfil do usuario")]
        public PerfilEnum? Perfil { get; set;}     
    }
}
