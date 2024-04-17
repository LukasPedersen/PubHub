using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubSubscriptionPubHubReader
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("SubscriptionID")]
        public Guid PubHubSubscriptionSubscriptionID { get; set; }

        [ForeignKey("ReaderID")]
        public Guid PubHubReaderReaderID { get; set; }
    }
}
