using EconomyProject.Entity.Concrete;

namespace EconomyProject.Data.Abstract
{
    public interface IUser
    {
        User GetById(int id);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);

        bool LoginUserByUsernameAndPassword(string username, string password);
    }
}
