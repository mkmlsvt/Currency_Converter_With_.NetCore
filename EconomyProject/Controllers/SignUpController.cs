using EconomyProject.Business.Concrete;
using EconomyProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EconomyProject.Controllers
{
    public class SignUpController : Controller
    {
        UserManager userManager = new UserManager();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user, string verifyPassword)
        {
            if (user.Password == verifyPassword)
            {
                userManager.UserAdd(user);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.errorVerify = "Parolalar aynı olmalı";
                return View();
            }

        }
    }
}
