using SubscriptionManager.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SubscriptionManager.Data
{
    public class SubscriptionDbRepository : ISubscriptionDbRepository
    {
        private readonly SubscriptionDbContext _context;
        public SubscriptionDbRepository(SubscriptionDbContext context)
        {
            _context = context;
        }

        public Task<User> AddUser(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> DeleteUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> UpdateUser(User entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
