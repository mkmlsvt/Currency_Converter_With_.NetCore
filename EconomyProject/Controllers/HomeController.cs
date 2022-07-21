using EconomyProject.API.Controllers;
using EconomyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EconomyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(IFormCollection datas)
        {
            string baseBirim = datas["fromCurrencyUnit"].ToString().ToUpper();
            string toBirim = datas["toCurrencyUnit"].ToString().ToUpper();
            int quantity = int.Parse(datas["quantityCurrency"]);
            CollectController collectApi = new CollectController(baseBirim, toBirim, quantity);
            double calculatedCurrancy = collectApi.getRequestApi();
            if (calculatedCurrancy > 0)
            {
                ViewBag.calculatedData = calculatedCurrancy.ToString();
            }
            else
            {
                ViewBag.calculatedData = "Girdiğiniz değerleri kontrol edin";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
