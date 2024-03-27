using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PubHubAPI.Data.Models
{
    public class PubHubSubscription
    {
        [Key]
        public Guid SubscriptionID { get; set; }

        [Required]
        public string Title { get; set; }

        public double Price { get; set; } = 0;

        [Required]
        public DateTime StartDate { get; set; }

        [AllowNull]
        public DateTime EndDate { get; set; }

        public string Message { get; set; } = "";

        public bool Active { get; set; } = true;

        //Relationships
        public List<PubHubEBook> EBooks { get; set; } = new();
    }
}
