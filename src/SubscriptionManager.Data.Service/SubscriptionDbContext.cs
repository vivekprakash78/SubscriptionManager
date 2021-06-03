
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<Subscription>().HasKey(s => s.ID);
        }

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
