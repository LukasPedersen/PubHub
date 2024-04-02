using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace PubHubWeb.Data.Models
{
    public class PubHubReceipt
    {
        [Key]
        public Guid ReceiptID { get; set; }

        [Required]
        public Guid EntityID { get; set; }

        [Required]
        public Guid Acquired { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
