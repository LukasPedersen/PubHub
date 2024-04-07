using System.ComponentModel.DataAnnotations;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubReader
    {
        [Key]
        public Guid ID { get; set; }
        public PubHubEBook EBook { get; set; }
        public PubHubReader Reader { get; set; }
    }
}
