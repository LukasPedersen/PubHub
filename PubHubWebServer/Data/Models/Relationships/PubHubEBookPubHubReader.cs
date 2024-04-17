using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models.Relationships
{
    public class PubHubEBookPubHubReader
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("EBookID")]
        public Guid PubHubEBookEBookID { get; set; }

        [ForeignKey("ReaderID")]
        public Guid PubHubReaderReaderID { get; set; }
    }
}
