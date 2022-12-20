using Passwords.Data;
using Passwords.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly BancoContext _context;
        public CadastroRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }
        public List<PasswordModel> BuscarTodos()
        {
            return _context.Cadastros.ToList();
        }
        public PasswordModel Adicionar(PasswordModel cadastro)
        {
            _context.Cadastros.Add(cadastro);
            _context.SaveChanges();

            return cadastro;
        }

        public PasswordModel ListarPorId(int id)
        {
            return _context.Cadastros.FirstOrDefault(x => x.Id == id);
        }

        public PasswordModel Atualizar(PasswordModel cadastro)
        {
            PasswordModel cadastroDB = ListarPorId(cadastro.Id);

            if (cadastroDB == null) throw new SystemException("Eita! Houve um erro na atualização do cadastro! :C");

            cadastroDB.Nome = cadastro.Nome;
            cadastroDB.Senha = cadastro.Senha;
            cadastroDB.Email = cadastro.Email;

            _context.Cadastros.Update(cadastroDB);
            _context.SaveChanges();
            return cadastroDB;

        }

        public bool Apagar(int id)
        {
            PasswordModel cadastroDB = ListarPorId(id);

            if (cadastroDB == null) throw new SystemException("Eita! Houve um erro na remoção do cadastro! :C");

            _context.Cadastros.Remove(cadastroDB);
            _context.SaveChanges();

            return true;

        }
    }
}
