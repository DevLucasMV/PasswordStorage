using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Passwords.Models;

namespace Passwords.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<PasswordModel> Cadastros { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}


