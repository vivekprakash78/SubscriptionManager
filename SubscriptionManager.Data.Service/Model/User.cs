
namespace SubscriptionManager.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public int UserID;
        public string FullName;
        public string UserName;
        public DateTime UserSince;
        public IEnumerable<Subscription> subscriptions;
    }
}
