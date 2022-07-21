using EconomyProject.Entity.Constants;
using EconomyProject.Entity.JsonEntities;
using Newtonsoft.Json;
using RestSharp;
using System;


namespace EconomyProject.API.Controllers
{
    public class CollectController
    {
        public string url { get; set; }
        public CollectController(string baseUnit, string toUnit, int quantity)
        {
            url = "https://api.collectapi.com/economy/exchange?int=" + quantity.ToString() + "&to=" + toUnit + "&base=" + baseUnit;
        }
        public double getRequestApi()
        {
            try
            {
                var client = new RestClient(this.url);
                RestRequest request = new RestRequest(this.url, Method.Get);
                request.AddHeader("authorization", Constant.myApiKey);
                request.AddHeader("content-type", "application/json");
                var response = client.Execute(request);
                JsonSuccess jsonSuccess = JsonConvert.DeserializeObject<JsonSuccess>(response.Content);
                double calculatedCurrancy = jsonSuccess.result.data[0].Calculated;
                return calculatedCurrancy;
            }
            catch (Exception)
            {
                return 0;
            }


        }
    }
}
