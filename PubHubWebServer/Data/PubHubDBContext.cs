using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PubHubWebServer.Data.Models;

namespace PubHubWebServer.Data
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<ApplicationUser> CharlottePublisher = new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = "1ba72301-41a5-4369-8de3-c9a15d674723",
                    UserName = "Charlotte M.",
                    NormalizedUserName = "CHARLOTTE M.",
                    Email = "CharlotteM@hotmail.com",
                    NormalizedEmail = "CHARLOTTEM@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEKBua+VGrQ1yd1oLxDj3fGg0pg5fgcZPJngxJpUawR35V0d04nZl/LbllM0h1GzmGQ==",
                    SecurityStamp = "W2RXQEP3EVH67RDL2666FU55UOWZUFEX",
                    ConcurrencyStamp = "5ee96d6b-7b08-4b38-9b71-96e53057a95b",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = Guid.Parse("8392396E-27CE-469E-954C-4E108B827875")
                }
            };

            List<PubHubEBook> Books = new List<PubHubEBook>()
            {
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "Worthy of his name",
                    Description = "This ebook is for the use of anyone anywhere in the United States and most other parts of the world at no cost and with almost no restrictions whatsoever. You may copy it, give it away or re-use it under the terms of the Project Gutenberg License included with this ebook or online at www.gutenberg.org. If you are not located in the United States, you will have to check the laws of the country where you are located before using this eBook.",
                    AuthorNames = "Eglanton Thorne",
                    PageCount = 154,
                    Genre = "krimi",
                    Price = 214.95,
                    BorrowPrice = 189.95,
                    FilePath = "Worthy-of-his-name"
                },
                new PubHubEBook()
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The-Little-Duke:-Richard-the-Fearless",
                    Description = "Richard I (28 August 933 – 20 November 996), also known as Richard the Fearless (French, Richard Sans-Peur), was the Count of Rouen from 942 to 996. Dudo of Saint-Quentin, whom Richard commissioned to write the \"De moribus et actis primorum Normanniae ducum\" (Latin, \"On the Customs and Deeds of the First Dukes of Normandy\"), called him a Dux.",
                    AuthorNames = "Charlotte M. Yonge",
                    PageCount = 198,
                    Genre = "krimi",
                    Price = 130.95,
                    BorrowPrice = 65.95,
                    FilePath = "Beginners-zoology"
                },
                new PubHubEBook()
                {
                    
                }
            };

            builder.Entity<ApplicationUser>(a =>
            {
                a.HasData(new ApplicationUser
                {
                    Id = "1ba72301-41a5-4369-8de3-c9a15d674723",
                    UserName = "Charlotte M.",
                    NormalizedUserName = "CHARLOTTE M.",
                    Email = "CharlotteM@hotmail.com",
                    NormalizedEmail = "CHARLOTTEM@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEKBua+VGrQ1yd1oLxDj3fGg0pg5fgcZPJngxJpUawR35V0d04nZl/LbllM0h1GzmGQ==",
                    SecurityStamp = "W2RXQEP3EVH67RDL2666FU55UOWZUFEX",
                    ConcurrencyStamp = "5ee96d6b-7b08-4b38-9b71-96e53057a95b",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = Guid.Parse("8392396E-27CE-469E-954C-4E108B827875")
                });
            });

            builder.Entity<PubHubPublisher>().HasData(new PubHubPublisher
            {
                PublisherID = Guid.Parse("8392396E-27CE-469E-954C-4E108B827875"),
                Name = "Yonge, Charlotte M.",
                MyUser = CharlottePublisher,
                EBooks = CharlottePublisherBooks
            });

            builder.Entity<PubHubEBook>().HasData();
            builder.Entity<PubHubEBook>().HasData(new PubHubEBook
            {
                EBookID = Guid.NewGuid(),
                Title = "Beginners' zoology",
                Description = "Fortunately for the animals, the plants oxidize very little of the substances built up by them, Since they do not move about nor need to keep themselves warm. We notice that animals are constantly using plant substances for food, and constantly drawing the air into their bodies. If the sun light had not enabled the green plant to store up these substances and to set free the oxygen (fig. Animals would have no food to eat nor air to breathe; hence we may say that the sunlight is indirectly the source Of the life and energy of animals. Mushrooms and other plants without green matter cannot set oxygen free",
                AuthorNames = "Walter M. Coleman",
                PageCount = 198,
                Genre = "krimi",
                Price = 130.95,
                BorrowPrice = 65.95,
                FilePath = "Beginners-zoology"
            });
            builder.Entity<PubHubEBook>().HasData();
        }
    }
}
