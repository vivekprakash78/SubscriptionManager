
namespace SubscriptionManager.Data
{
    using SubscriptionManager.Data.Model;
    using System.Collections.Generic;

    public interface ISubscriptionDbRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        bool AddUser(User entity);
        bool UpdateUser(User entity);
        bool DeleteUser(int id);
    }
}
