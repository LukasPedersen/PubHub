using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWeb.Data.Models
{
    public class PubHubPublisher
    {
        public Guid PublisherID { get; set; }

        [Required]
        public string Name { get; set; }

        public ApplicationUser MyUser { get; set; }

        //Relationships
        public List<PubHubSubscription> Subscriptions { get; set; } = new();

        public List<PubHubEBook> EBooks { get; set; } = new();
    }
}
