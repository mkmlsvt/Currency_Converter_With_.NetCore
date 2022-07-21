using EconomyProject.Entity.Concrete;

namespace EconomyProject.Business.Abstract
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
