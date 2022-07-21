using EconomyProject.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EconomyProject.Controllers
{
    public class Login : Controller
    {
        UserManager userManager= new UserManager();
        public IActionResult Index()
        {
            HttpContext.Session.Remove("username");
            return View();
        }
        [HttpPost]
        public IActionResult Index(string password, string username)
        {
            if(userManager.LoginUserByUsernameAndPassword(username, password))
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.errorLogin = "Kullanıcı Adı Veya Parola Hatalı";
                return View();
            }
            
        }
    }
}
