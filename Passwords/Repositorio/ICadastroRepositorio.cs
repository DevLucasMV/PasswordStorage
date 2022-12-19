using Passwords.Models;
using System.Collections.Generic;

namespace Passwords.Repositorio
{
    public interface ICadastroRepositorio
    {
        List<PasswordModel> BuscarTodos();

        PasswordModel Adicionar(PasswordModel cadastro);
    }
}
