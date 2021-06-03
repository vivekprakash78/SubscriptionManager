
namespace SubscriptionManager.Data
{
    using SubscriptionManager.Data.Model;
    using System.Collections.Generic;
    using System.Linq;

    public class SubscriptionDbRepository : ISubscriptionDbRepository
    {
        private readonly SubscriptionDbContext _context;
        public SubscriptionDbRepository(SubscriptionDbContext context)
        {
            _context = context;
        }

        public bool AddUser(User entity)
        {
            try
            {
                _context.Users.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            var entity = _context.Users.Find(id);
            if (entity != null)
            {
                try
                {
                    _context.Users.Remove(entity);
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return true;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.AsEnumerable();
        }

        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public bool UpdateUser(User entity)
        {
            try
            {
                _context.Users.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
