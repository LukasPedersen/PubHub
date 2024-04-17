using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using YamlDotNet.Core.Tokens;
using PubHubWebServer.Data.Models.Relationships;

namespace PubHubWebServer.Data.Models
{
    public class PubHubReader
    {
        [Key]
        public Guid ReaderID { get; set; }

        public string ApplicationUserId { get; set; } = Guid.NewGuid().ToString();

        //Relationships
        public ApplicationUser ApplicationUser { get; set; }
        public List<PubHubSubscriptionPubHubReader> Subscriptions { get; set; }
        public List<PubHubEBookPubHubReader> EBooks { get; set; }
    }
}
