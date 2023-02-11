using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Passwords.Models;
using System.Collections.Generic;
using System.Linq;

namespace Passwords.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1, username="admin",password="admin"},
                 new UserModel{id=1, username="admin1",password="admin1"},
            };

            return users;
        }

        [HttpPost]
        public IActionResult Verify(UserModel usr) 
        
        {
            var u = PutValue();
            var ue = u.Where(u => u.username.Equals(usr.username));
            var up=ue.Where(p => p.password.Equals(usr.password));

            if(up.Count()==1)
            {
                ViewBag.message = "Logado com sucesso!!";
                return RedirectToAction("Index", "Home");
            }

            else
            {

                ViewBag.message = "Opa! Algo tem algo errado!";
                return View("Login");
            }
        }
    }
        
}
