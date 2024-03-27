using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PubHubAPI.Data.Models;

namespace PubHubAPI.Data
{
    public class PubHubDBContext : IdentityDbContext
    {
        DbSet<PubHubUser> Users {  get; set; }
        DbSet<PubHubReader> Readers {  get; set; }
        DbSet<PubHubPublisher> Publishers { get; set; }
        DbSet<PubHubSubscription> Subscriptions { get; set; }
        DbSet<PubHubEBook> EBooks { get; set; }
        DbSet<PubHubLog> Logs { get; set; }
        DbSet<PubHubReceipt> Receipts { get; set; }
        public PubHubDBContext(DbContextOptions<PubHubDBContext> options) : base(options)
        {

        }
    }
}
