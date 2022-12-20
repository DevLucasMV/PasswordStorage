using Passwords.Models;
using System.Collections.Generic;

namespace Passwords.Repositorio
{
    public interface ICadastroRepositorio
    {

        PasswordModel ListarPorId(int id);
        List<PasswordModel> BuscarTodos();

        PasswordModel Adicionar(PasswordModel cadastro);

        PasswordModel Atualizar(PasswordModel cadastro);
    }
}
