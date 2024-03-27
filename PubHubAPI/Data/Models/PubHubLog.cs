using System.ComponentModel.DataAnnotations;

namespace PubHubAPI.Data.Models
{
    public class PubHubLog
    {
        [Key]
        public Guid LogID { get; set; }

        [Required]
        public Guid EntityID { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
