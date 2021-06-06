
namespace SubscriptionManager.Data.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
