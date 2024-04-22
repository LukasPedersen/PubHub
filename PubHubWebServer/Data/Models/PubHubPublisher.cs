using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using PubHubWebServer.Data.Models.Relationships;

namespace PubHubWebServer.Data.Models
{
    public class PubHubPublisher
    {
        [Key]
        public Guid PublisherID { get; set; }

        [Required]
        public string Name { get; set; }

        [AllowNull]
        public string ApplicationUserId { get; set; } = Guid.NewGuid().ToString();

        //Relationships
        public ApplicationUser ApplicationUser { get; set; }
        public List<PubHubSupscriptionPubHubPublisher> Subscriptions { get; set; }
        public List<PubHubEBookPubHubPublisher> EBooks { get; set; }
    }
}
