using EconomyProject.Business.Abstract;
using EconomyProject.Data.Repositories;
using EconomyProject.Entity.Concrete;
using System;

namespace EconomyProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        UserRepository userRepository;
        public UserManager()
        {
            userRepository = new UserRepository();
        }
        public void GetUserById(int id)
        {
            userRepository.GetById(id);
        }

        public bool LoginUserByUsernameAndPassword(string username, string password)
        {
            return userRepository.LoginUserByUsernameAndPassword(username, password);
        }

        public void UserAdd(User user)
        {
            userRepository.AddUser(user);
        }

        public void UserDelete(User user)
        {
            throw new NotImplementedException();
        }

        public void UserUpdate(User user)
        {
            throw new NotImplementedException();
        }
    }
}
