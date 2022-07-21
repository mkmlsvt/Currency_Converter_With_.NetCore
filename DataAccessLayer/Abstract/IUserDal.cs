using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal
    {
        User GetById(int id);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);

        bool LoginUserByUsernameAndPassword(string username, string password);
    }
}
