
using EconomyProject.API.Controllers;
using NUnit.Framework;


namespace EconomyProject.Tests
{
    public class CollectApiTest
    {
        string _base,_to; int quantity;
        CollectController _sut;
        [SetUp]
        public void Setup()
        {
             _base = "rohanGumusu";
             _to = "starKurdu";
             quantity = 5;
             _sut = new CollectController(_base,_to,quantity);
        }
        [Test]
        public void GetRequestApi_WhenParamsİsNotSuitable_ShouldReturnZero()
        {
            double result =  _sut.getRequestApi();
            Assert.AreEqual(0, result);
        }

    }
}
