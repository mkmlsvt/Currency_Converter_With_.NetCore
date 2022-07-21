using BusinessLayer.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class UserManagerLoginTest
    {
        UserManager userManager;
        [SetUp]
        public void Setup()
        {
            userManager = new UserManager();
        }
        [Test]
        public void TestLogin()
        {
            var username = "alex";
            var password = "DeSouza";
            bool isLogin  = userManager.LoginUserByUsernameAndPassword(username, password);
            Assert.IsTrue(isLogin);
        }
    }
}
