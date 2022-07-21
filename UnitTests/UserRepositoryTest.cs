using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using NUnit.Framework;
using System;
using System.Linq;

namespace UnitTests
{
    public class UserRepositoryTest
    {
        UserRepository userRepository ;
        [SetUp]
        public void Setup()
        {
            userRepository = new UserRepository();
        }
        [Test] 
        public void AddDatabase_Works()
        {
            User user = new User();
            user.Username = "alex";
            user.Password = "DeSouza";
            userRepository.AddUser(user);
            Context c = new Context();
            User userControl = c.Users.FirstOrDefault(x=>x.Username==user.Username&&x.Password==user.Password);
            Assert.IsNotNull(userControl);
        }
    }
}
