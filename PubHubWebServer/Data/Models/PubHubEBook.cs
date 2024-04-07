using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PubHubWebServer.Data.Models
{
    public class PubHubEBook
    {
        [Key]
        public Guid EBookID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; } = string.Empty;

        [Required]
        public string AuthorNames { get; set; }

        [Required]
        public int PageCount { get; set; }

        [Required]
        public string Genre { get; set; }

        public uint DownloadCount { get; set; } = 0;

        [Required]
        public double Price { get; set; }

        public double BorrowPrice { get; set; } = 0;

        [Required]
        public string FilePath { get; set; }
    }
}
