using BusinessLayer.ReqAPI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class CollectApiTest
    {
        string _base,_to; int quantity;
        CollectApi collectApi;
        [SetUp]
        public void Setup()
        {
             _base = "rohanGumusu";
             _to = "starKurdu";
             quantity = 5;
             collectApi = new CollectApi(_base,_to,quantity);
        }
        [Test]
        public void ApiResShouldBeZero()
        {
            double result =  collectApi.getRequestApi();
            Assert.AreEqual(0, result);
        }

    }
}
