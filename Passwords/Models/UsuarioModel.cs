using Passwords.Enum;
using System;

namespace Passwords.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set;}
        public string Email { get; set;}
        public PerfilEnum Perfil { get; set;}
        public string Password { get; set;} 
        public DateTime DataCadastro { get; set;} 
        public DateTime? DataDeAtualizacao { get; set;}

    }
}
