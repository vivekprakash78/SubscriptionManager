namespace SubscriptionManager.Data
{
    public class SubscriptionDbRepository : ISubscriptionDbRepository
    {
        private readonly SubscriptionDbContext _context;
        public SubscriptionDbRepository(SubscriptionDbContext context)
        {
            _context = context;
        }
    }
}
