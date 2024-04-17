using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubSupscriptionPubHubPublisher
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("SubscriptionID")]
        public Guid PubHubSubscriptionSubscriptionID { get; set; }

        [ForeignKey("PublisherID")]
        public Guid PubHubPublisherPublisherID { get; set; }
    }
}
