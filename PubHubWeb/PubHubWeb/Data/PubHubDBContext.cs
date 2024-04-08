using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PubHubWeb.Data.Models;

namespace PubHubWeb.Data
{
    public class PubHubDBContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> Users {  get; set; }
        public DbSet<PubHubReader> Readers {  get; set; }
        public DbSet<PubHubPublisher> Publishers { get; set; }
        public DbSet<PubHubSubscription> Subscriptions { get; set; }
        public DbSet<PubHubEBook> EBooks { get; set; }
        public DbSet<PubHubLog> Logs { get; set; }
        public DbSet<PubHubReceipt> Receipts { get; set; }
        public PubHubDBContext(DbContextOptions<PubHubDBContext> options) : base(options)
        {

        }
    }
}
