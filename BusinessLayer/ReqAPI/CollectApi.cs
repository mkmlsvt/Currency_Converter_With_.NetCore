using EntityLayer.JsonEntities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ReqAPI
{
    public class CollectApi
    {
        public static string myApiKey = "apikey 23vsDFgYsbgtqeT5M6P5FS:449DGHNRrIEtBIaHMYUJkc";
        public string url { get; set; }
        public CollectApi(string baseUnit, string toUnit, int quantity)
        {
            url = "https://api.collectapi.com/economy/exchange?int=" + quantity.ToString() + "&to=" + toUnit + "&base=" + baseUnit;
        }
        public double getRequestApi()
        {
            try
            {
                var client = new RestClient(this.url);
                RestRequest request = new RestRequest(this.url, Method.Get);
                request.AddHeader("authorization", myApiKey);
                request.AddHeader("content-type", "application/json");
                var response = client.Execute(request);
                JsonSuccess jsonSuccess = JsonConvert.DeserializeObject<JsonSuccess>(response.Content);
                double calculatedCurrancy = jsonSuccess.result.data[0].calculated;
                return calculatedCurrancy;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
            
        }
    }
}
