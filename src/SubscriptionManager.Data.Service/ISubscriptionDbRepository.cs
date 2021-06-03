using SubscriptionManager.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SubscriptionManager.Data
{
    public interface ISubscriptionDbRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task<User> AddUser(User entity);
        Task<User> UpdateUser(User entity);
        Task<User> DeleteUser(int id);
    }
}
