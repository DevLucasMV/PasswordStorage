using Microsoft.AspNetCore.Mvc;

namespace Passwords.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
