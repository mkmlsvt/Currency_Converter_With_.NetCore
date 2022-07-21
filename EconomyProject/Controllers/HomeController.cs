using BusinessLayer.ReqAPI;
using EconomyProject.Models;
using EntityLayer.JsonEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            CollectApi collectApi = new CollectApi(baseBirim,toBirim,quantity);
            double calculatedCurrancy = collectApi.getRequestApi();
            if(calculatedCurrancy > 0)
            {
                ViewBag.calculatedData = calculatedCurrancy.ToString();
            }
            else
            {
                ViewBag.calculatedData = "Girdiğiniz değerleri kontrol edin";
            }
            /*var client = new RestClient(collectApi.url);
            RestRequest request = new RestRequest(collectApi.url,Method.Get);
            request.AddHeader("authorization", CollectApi.myApiKey);
            request.AddHeader("content-type", "application/json");
            var response = client.Execute(request);
            JsonSuccess jsonSuccess = JsonConvert.DeserializeObject<JsonSuccess>(response.Content);
            double calculatedCurrancy = jsonSuccess.result.data[0].calculated;
            ViewBag.calculatedData = calculatedCurrancy.ToString();*/
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
