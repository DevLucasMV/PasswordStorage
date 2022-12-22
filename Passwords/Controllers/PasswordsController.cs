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
        public IActionResult Editar(int id)
        {
           PasswordModel cadastro = _cadastroRepositorio.ListarPorId(id);
            return View(cadastro);
        }

        public IActionResult Apagar(int id)
        {
            _cadastroRepositorio.Apagar(id);
            return RedirectToAction("index");

        }
        public IActionResult ApagarConfirmacao(int id)
        {
            PasswordModel cadastro = _cadastroRepositorio.ListarPorId(id);
            return View(cadastro);
        }

        [HttpPost]
        public IActionResult Criar(PasswordModel cadastro)
        {

            if (ModelState.IsValid)
            {
                _cadastroRepositorio.Adicionar(cadastro);
                return RedirectToAction("Index");
            }
            else
            {
                return View(cadastro);
            }

        }

        [HttpPost]
        public IActionResult Alterar(PasswordModel cadastro)
        {
            if (ModelState.IsValid)
            {
                _cadastroRepositorio.Atualizar(cadastro);
                return RedirectToAction("Index");
            }
            return View("Editar", cadastro);

        }
    }
}
