using Passwords.Data;
using Passwords.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CadastroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<PasswordModel> BuscarTodos()
        {
            return _bancoContext.Cadastros.ToList();
        }
        public PasswordModel Adicionar(PasswordModel cadastro)
        {
            _bancoContext.Cadastros.Add(cadastro);
            _bancoContext.SaveChanges();

            return cadastro;
        }

      
    }
}
