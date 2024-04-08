using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubSubscription
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("EBookID")]
        public Guid PubHubEBookEBookID { get; set; }

        [ForeignKey("SubscriptionID")]
        public Guid PubHubSubscriptionSubscriptionID { get; set; }
    }
}
