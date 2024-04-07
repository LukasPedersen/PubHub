using System.ComponentModel.DataAnnotations;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubSupscriptionPubHubPublisher
    {
        [Key]
        public Guid ID { get; set; }
        public PubHubSubscription Subscription { get; set; }
        public PubHubPublisher Publisher { get; set; }
    }
}
