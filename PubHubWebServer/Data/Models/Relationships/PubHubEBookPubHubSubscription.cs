using System.ComponentModel.DataAnnotations;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubSubscription
    {
        [Key]
        public Guid ID { get; set; }
        public PubHubEBook EBook { get; set; }
        public PubHubSubscription Subscription { get; set; }
    }
}
