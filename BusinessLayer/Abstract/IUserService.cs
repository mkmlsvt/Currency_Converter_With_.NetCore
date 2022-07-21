using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void UserAdd(User user);
        void UserDelete(User user);
        void UserUpdate(User user);
        void GetUserById(int id);
        bool LoginUserByUsernameAndPassword(string username, string password);
    }
}
