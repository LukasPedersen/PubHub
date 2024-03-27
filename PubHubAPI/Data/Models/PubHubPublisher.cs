using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubAPI.Data.Models
{
    public class PubHubPublisher
    {
        [Key]
        public Guid PublisherID { get; set; }

        [Required]
        public string Name { get; set; }

        public PubHubUser MyUser { get; set; }

        //Relationships
        public List<PubHubSubscription> Subscriptions { get; set; } = new();

        public List<PubHubEBook> EBooks { get; set; } = new();
    }
}
