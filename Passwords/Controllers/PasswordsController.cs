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

            try
            {
                bool apagado = _cadastroRepositorio.Apagar(id);
                if (apagado) {     
                TempData["MensagemSucesso"] = "Cadastro apagado com sucesso!";
                }
                else 
                {
                    TempData["MensagemErro"] = "Eita! Não foi possivel apagar o cadastro!}";
             
                }
                return RedirectToAction("index");
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita! Não foi possivel apagar o cadastro! Erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
        public IActionResult ApagarConfirmacao(int id)
        {
            PasswordModel cadastro = _cadastroRepositorio.ListarPorId(id);
            return View(cadastro);
        }

        [HttpPost]
        public IActionResult Criar(PasswordModel cadastro)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _cadastroRepositorio.Adicionar(cadastro);
                    TempData["MensagemSucesso"] = "Cadastro efetuado com sucesso!";
                    return RedirectToAction("Index");
                }
                
                    return View(cadastro);
                
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita! Não foi possivel cadastrar! Erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(PasswordModel cadastro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _cadastroRepositorio.Atualizar(cadastro);
                    TempData["MensagemSucesso"] = "Cadastro alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", cadastro);

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Eita! Não foi possivel alterar o cadastro! Erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
