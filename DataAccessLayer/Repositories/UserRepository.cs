using EconomyProject.Data.Abstract;
using EconomyProject.Data.Concrete;
using EconomyProject.Entity.Concrete;
using System;
using System.Linq;

namespace EconomyProject.Data.Repositories
{
    public class UserRepository : IUser
    {
        Context c = new Context();
        public void AddUser(User user)
        {
            c.Users.Add(user);
            c.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            User userTmp = c.Users.FirstOrDefault(x => x.UserId == id);
            return userTmp;
        }

        public bool LoginUserByUsernameAndPassword(string username, string password)
        {
            User userLogin = c.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (userLogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
