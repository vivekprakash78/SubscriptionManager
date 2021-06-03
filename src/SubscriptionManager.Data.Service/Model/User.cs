
namespace SubscriptionManager.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public int ID;
        public string FullName;
        public string UserName;
        public DateTime UserSince;
        public ICollection<Subscription> Subscriptions;
    }
}
