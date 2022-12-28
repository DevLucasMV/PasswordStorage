﻿using Passwords.Models;
using System.Collections.Generic;

namespace Passwords.Repositorio

{
    public interface IUsuarioRepositorio
    {

        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
