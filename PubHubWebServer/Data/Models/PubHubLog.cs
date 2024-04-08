using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PubHubWebServer.Data.Models
{
    public class PubHubLog
    {
        [Key]
        public Guid LogID { get; set; }

        [AllowNull]
        public Guid? EntityID { get; set; }

        [Required]
        public LogType LogType { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
    public enum LogType
    {
        Information,
        Warning,
        Error
    }
}
