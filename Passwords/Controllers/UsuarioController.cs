using Microsoft.AspNetCore.Mvc;
using Passwords.Models;
using Passwords.Repositorio;
using System.Collections.Generic;

namespace Passwords.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Cadastro efetuado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(usuario);

            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita! Não foi possivel cadastrar! Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
                    
        }
        public IActionResult ApagarConfirmacao(int id)

        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {

            try
            {
                bool apagado = _usuarioRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Eita! Não foi possivel apagar o usuario!}";

                }
                return RedirectToAction("index");
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita! Não foi possivel apagar o usuario! Erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

    }
}
