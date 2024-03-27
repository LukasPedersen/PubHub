using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PubHubAPI.Data.Models
{
    public class PubHubUser : IdentityUser
    {
        public IEnumerable<IdentityRole>? Roles { get; set; }

        [Required]
        public bool Active { get; set; } = true;

        public Guid MyPubHubAccount { get; set; }
    }
}
