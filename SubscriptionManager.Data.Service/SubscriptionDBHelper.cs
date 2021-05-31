namespace SubscriptionManager.Data
{
    public class SubscriptionDBHelper : ISubscriptionDBHelper
    {
        private readonly SubscriptionDbContext _context;
        public SubscriptionDBHelper(SubscriptionDbContext context)
        {
            _context = context;
        }
    }
}
