using Microsoft.AspNetCore.Mvc;
using Passwords.Models;
using Passwords.Repositorio;
using System.Collections.Generic;

namespace Passwords.Controllers
{
    public class PasswordsController : Controller
    {

        private readonly ICadastroRepositorio _cadastroRepositorio;
        public PasswordsController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;   
        }
        public IActionResult Index()
        {
            List<PasswordModel> cadastros = _cadastroRepositorio.BuscarTodos();
            return View(cadastros);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PasswordModel cadastro)
        {
            _cadastroRepositorio.Adicionar(cadastro);
            return RedirectToAction("Index");
          
        }
    }
}
