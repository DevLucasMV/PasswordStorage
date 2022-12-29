using Microsoft.AspNetCore.Mvc;
using Passwords.Models;
using Passwords.Repositorio;
using System;

namespace Passwords.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController (IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio= usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                
                    if (usuario != null)
                    {
                        if(usuario.SenhaValida(loginModel.Senha)) { 
                        return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = "Senha invalida.";
                    }

                    TempData["MensagemErro"] = "Senha ou Login invalidos.";
                }

                return View("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Eita! Não foi possivel logar! {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
