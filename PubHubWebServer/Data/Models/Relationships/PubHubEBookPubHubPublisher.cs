using System.ComponentModel.DataAnnotations;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubPublisher
    {
        [Key]
        public Guid ID { get; set; }
        public PubHubEBook EBook { get; set; }
        public PubHubPublisher Publisher { get; set; }
    }
}
