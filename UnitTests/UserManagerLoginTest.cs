using EconomyProject.Business.Concrete;
using NUnit.Framework;

namespace EconomyProject.Tests
{
    public class UserManagerLoginTest
    {
        UserManager _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new UserManager();
        }
        [Test]
        public void LoginUserByUsernameAndPassword_TrueStroy()
        {
            var username = "alex";
            var password = "DeSouza";
            bool isLogin = _sut.LoginUserByUsernameAndPassword(username, password);
            Assert.IsTrue(isLogin);
        }
    }
}
