
namespace SubscriptionManager.Data.Model
{
    using SubscriptionManager.Data.Enumeration;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public SubscriptionProvider Provider { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

    }
}
