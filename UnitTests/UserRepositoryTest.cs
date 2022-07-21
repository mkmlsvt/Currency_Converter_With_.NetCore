using EconomyProject.Data.Concrete;
using EconomyProject.Data.Repositories;
using EconomyProject.Entity.Concrete;
using NUnit.Framework;
using System.Linq;

namespace EconomyProject.Tests
{
    public class UserRepositoryTest
    {
        UserRepository _sut; // system under test
        [SetUp]
        public void Setup()
        {
            _sut = new UserRepository();
        }
        [Test]
        public void AddUser_TrueStory()
        {
            User user = new User();
            user.Username = "alex";
            user.Password = "DeSouza";
            _sut.AddUser(user);
            Context c = new Context();
            User userControl = c.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            Assert.IsNotNull(userControl);
        }
    }
}
