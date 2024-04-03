using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace PubHubWeb.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public IEnumerable<IdentityRole>? Roles { get; set; }

        [Required]
        public bool Active { get; set; } = true;

        public Guid MyPubHubAccount { get; set; }
    }

}
