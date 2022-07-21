using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
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
            return userRepository.LoginUserByUsernameAndPassword(username,password);
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
