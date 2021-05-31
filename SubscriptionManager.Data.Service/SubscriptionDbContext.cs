
namespace SubscriptionManager.Data
{
    #region Usings
    using Microsoft.EntityFrameworkCore;
    using SubscriptionManager.Data.Model;
    #endregion

    public class SubscriptionDbContext : DbContext
    {
        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options) : base(options)
        {

        }

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
