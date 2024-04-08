using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubPublisher
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("EBookID")]
        public Guid PubHubEBookEBookID { get; set; }

        [ForeignKey("PublisherID")]
        public Guid PubHubPublisherPublisherID { get; set; }
    }
}
