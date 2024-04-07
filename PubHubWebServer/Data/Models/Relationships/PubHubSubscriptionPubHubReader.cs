using System.ComponentModel.DataAnnotations;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubSubscriptionPubHubReader
    {
        [Key]
        public Guid ID { get; set; }
        public PubHubSubscription Subscription { get; set; }
        public PubHubReader Reader { get; set; }
    }
}
