using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PubHubWebServer.Data.Models;
using PubHubWebServer.Data.Models.Relationships;
using System.Reflection.Emit;

namespace PubHubWebServer.Data
{
    public class PubHubDBContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<PubHubReader> Readers { get; set; }
        public DbSet<PubHubPublisher> Publishers { get; set; }
        public DbSet<PubHubSubscription> Subscriptions { get; set; }
        public DbSet<PubHubEBook> EBooks { get; set; }
        public DbSet<PubHubLog> Logs { get; set; }
        public DbSet<PubHubReceipt> Receipts { get; set; }

        public DbSet<PubHubEBookPubHubSubscription> EBookSubscriptions { get; set; }
        public DbSet<PubHubEBookPubHubReader> EBookReaders { get; set; }
        public DbSet<PubHubEBookPubHubPublisher> EBookPublishers { get; set; }
        public DbSet<PubHubSubscriptionPubHubReader> SubscriptionPublishers { get; set; }
        public DbSet<PubHubSubscriptionPubHubReader> SubscriptionReaders { get; set; }

        public PubHubDBContext(DbContextOptions<PubHubDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<PubHubReader>().HasOne(r => r.ApplicationUser).WithMany().HasForeignKey(r => r.ApplicationUserId);
            builder.Entity<PubHubPublisher>().HasOne(r => r.ApplicationUser).WithMany().HasForeignKey(r => r.ApplicationUserId);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            List<Guid> applicationUserIDs = GetRandomGuids(5);
            List<Guid> publisherIDs = GetRandomGuids(2);
            List<Guid> readerIDs = GetRandomGuids(2);
            List<Guid> subscriptionIDs = GetRandomGuids(4);
            List<Guid> bookIDs = GetRandomGuids(8);
            List<Guid> roleIDs = GetRandomGuids(3);

            List<ApplicationUser> applicationUsers = new();
            List<PubHubPublisher> publishers = new();
            List<PubHubReader> readers = new();
            List<PubHubSubscription> subscriptions = new();
            List<PubHubEBook> books = new();

            #region Roles
            
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Publisher",
                NormalizedName = "PUBLISHER",
                Id = roleIDs[0].ToString(),
                ConcurrencyStamp = roleIDs[0].ToString()
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Reader",
                NormalizedName = "READER",
                Id = roleIDs[1].ToString(),
                ConcurrencyStamp = roleIDs[1].ToString()
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = roleIDs[2].ToString(),
                ConcurrencyStamp = roleIDs[2].ToString()
            });

            #endregion

            #region ApplicationUser Creation

            applicationUsers.Add(new ApplicationUser{
                Id = applicationUserIDs[0].ToString(),
                UserName = "Mellemgaard@hotmail.com",
                NormalizedUserName = "MELLEMGAARD@HOTMAIL.COM",
                Email = "Mellemgaard@hotmail.com",
                NormalizedEmail = "MELLEMGAARD@HOTMAIL.COM",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Active = true,
                MyPubHubAccount = publisherIDs[0]
            });
            applicationUsers.Add(new ApplicationUser
            {
                Id = applicationUserIDs[1].ToString(),
                UserName = "Nordic@hotmail.com",
                NormalizedUserName = "NORDIC@HOTMAIL.COM",
                Email = "Nordic@hotmail.com",
                NormalizedEmail = "NORDIC@HOTMAIL.COM",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Active = true,
                MyPubHubAccount = publisherIDs[1]
            });
            applicationUsers.Add(new ApplicationUser
            {
                Id = applicationUserIDs[2].ToString(),
                UserName = "lukas3302@hotmail.com",
                NormalizedUserName = "LUKAS3302@HOTMAIL.COM",
                Email = "lukas3302@hotmail.com",
                NormalizedEmail = "LUKAS3302@HOTMAIL.COM",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Active = true,
                MyPubHubAccount = readerIDs[0]
            });
            applicationUsers.Add(new ApplicationUser
            {
                Id = applicationUserIDs[3].ToString(),
                UserName = "ens2837@hotmail.com",
                NormalizedUserName = "JENS2837@HOTMAIL.COM",
                Email = "Jens2837@hotmail.com",
                NormalizedEmail = "JENS2837@HOTMAIL.COM",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Active = true,
                MyPubHubAccount = readerIDs[1]
            });
            applicationUsers.Add(new ApplicationUser
            {
                Id = applicationUserIDs[4].ToString(),
                UserName = "Admin@hotmail.com",
                NormalizedUserName = "ADMIN@HOTMAIL.COM",
                Email = "Admin@hotmail.com",
                NormalizedEmail = "ADMIN@HOTMAIL.COM",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Active = true,
            });

            PasswordHasher<ApplicationUser> ph1 = new PasswordHasher<ApplicationUser>();
            applicationUsers[0].PasswordHash = ph1.HashPassword(applicationUsers[0], "@Bob123");
            builder.Entity<ApplicationUser>().HasData(applicationUsers[0]);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleIDs[0].ToString(),
                UserId = applicationUsers[0].Id
            });

            PasswordHasher<ApplicationUser> ph2 = new PasswordHasher<ApplicationUser>();
            applicationUsers[1].PasswordHash = ph2.HashPassword(applicationUsers[1], "@Bob123");
            builder.Entity<ApplicationUser>().HasData(applicationUsers[1]);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleIDs[0].ToString(),
                UserId = applicationUsers[1].Id
            });

            PasswordHasher<ApplicationUser> ph3 = new PasswordHasher<ApplicationUser>();
            applicationUsers[2].PasswordHash = ph2.HashPassword(applicationUsers[2], "@Bob123");
            builder.Entity<ApplicationUser>().HasData(applicationUsers[2]);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleIDs[1].ToString(),
                UserId = applicationUsers[2].Id
            });

            PasswordHasher<ApplicationUser> ph4 = new PasswordHasher<ApplicationUser>();
            applicationUsers[3].PasswordHash = ph2.HashPassword(applicationUsers[3], "@Bob123");
            builder.Entity<ApplicationUser>().HasData(applicationUsers[3]);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleIDs[1].ToString(),
                UserId = applicationUsers[3].Id
            });

            PasswordHasher<ApplicationUser> ph5 = new PasswordHasher<ApplicationUser>();
            applicationUsers[4].PasswordHash = ph2.HashPassword(applicationUsers[4], "@Bob123");
            builder.Entity<ApplicationUser>().HasData(applicationUsers[4]);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleIDs[2].ToString(),
                UserId = applicationUsers[4].Id
            });

            #endregion

            #region Publisher Creation

            publishers.Add(new PubHubPublisher
            {
                PublisherID = publisherIDs[0],
                ApplicationUserId = applicationUserIDs[0].ToString(),
                Name = "Forlaget Mellemgaard"
            });
            publishers.Add(new PubHubPublisher
            {
                PublisherID = publisherIDs[1],
                ApplicationUserId = applicationUserIDs[1].ToString(),
                Name = "Buster Nordic"
            });

            foreach (PubHubPublisher publisher in publishers)
            {
                builder.Entity<PubHubPublisher>().HasData(publisher);
            }

            #endregion

            #region Reader Creation

            readers.Add(new PubHubReader
            {
                ReaderID = readerIDs[0],
                ApplicationUserId = applicationUserIDs[2].ToString()
            });
            readers.Add(new PubHubReader
            {
                ReaderID = readerIDs[1],
                ApplicationUserId = applicationUserIDs[3].ToString()
            });

            foreach (PubHubReader reader in readers)
            {
                builder.Entity<PubHubReader>().HasData(reader);
            }

            #endregion

            #region Ebooks Creation

            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[0],
                Title = "History of France",
                Description = "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.",
                AuthorNames = "Charlotte M. Yonge",
                PageCount = 78,
                Genre = "History",
                Price = 89,
                BorrowPrice = 21.95,
                FilePath = "History-of-France",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[1],
                Title = "The Pearl of the Andes A Tale of Love and Adventure",
                Description = "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.",
                AuthorNames = "Gustave Aimard",
                PageCount = 205,
                Genre = "Fantasy Adventure Romance Fiction",
                Price = 111,
                BorrowPrice = 45,
                FilePath = "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[2],
                Title = "The Pirates of the Prairies: Adventures in the American Desert",
                Description = "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.",
                AuthorNames = "Gustave Aimard",
                PageCount = 250,
                Genre = "History",
                Price = 89.95,
                BorrowPrice = 27,
                FilePath = "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[3],
                Title = "The Bee Hunters: A Tale of Adventure",
                Description = "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.",
                AuthorNames = "Gustave Aimard",
                PageCount = 240,
                Genre = "Action Adventure Fiction",
                Price = 132.95,
                BorrowPrice = 55,
                FilePath = "The-Bee-Hunters-A-Tale-of-Adventure",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[4],
                Title = "The Smuggler Chief",
                Description = "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.",
                AuthorNames = "Gustave Aimard",
                PageCount = 105,
                Genre = "Thriller Adventure Fiction",
                Price = 171,
                BorrowPrice = 51,
                FilePath = "The-Smuggler-Chief",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[5],
                Title = "Las noches mejicanas",
                Description = "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.",
                AuthorNames = "Gustave Aimard",
                PageCount = 240,
                Genre = "Thriller Adventure Fiction",
                Price = 159.95,
                BorrowPrice = 45,
                FilePath = "Las-noches-mejicanas",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[6],
                Title = "The Flying Horseman",
                Description = "\"The Flying Horseman\" is a thrilling tale penned by the French writer Gustave Aimard. Set in a world of adventure and danger, the story follows the journey of its titular character as he navigates challenges and confronts adversaries. With its gripping narrative and rich character development, this classic work is a testament to Aimard's literary genius.",
                AuthorNames = "Gustave Aimard",
                PageCount = 166,
                Genre = "Thriller French Adventure",
                Price = 299.95,
                BorrowPrice = 89.95,
                FilePath = "",
            });
            books.Add(new PubHubEBook
            {
                EBookID = bookIDs[7],
                Title = "The Guide of the Desert",
                Description = "Opening with loading a ship in Cape Horn, Chile, the book takes readers on an adventure throughout South America. Encounters with indigenous populations and learning to find common ground with others are at the heart of this tale, in many ways mirroring the author's own experiences.",
                AuthorNames = "Gustave Aimard",
                PageCount = 190,
                Genre = "Fiction Adventure",
                Price = 206.95,
                BorrowPrice = 43,
                FilePath = "",
            });

            foreach (PubHubEBook book in books)
            {
                builder.Entity<PubHubEBook>().HasData(book);
            }

            #endregion

            #region Subscriptions Creation

            subscriptions.Add(new PubHubSubscription
            {
                SubscriptionID = subscriptionIDs[0],
                Active = true,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                Message = "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details",
                Title = "Romance Mounth",
                Price = 119.95
            });
            subscriptions.Add(new PubHubSubscription
            {
                SubscriptionID = subscriptionIDs[1],
                Active = true,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                Message = "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes",
                Title = "Fantasy Hype",
                Price = 100,
            });
            subscriptions.Add(new PubHubSubscription
            {
                SubscriptionID = subscriptionIDs[2],
                Active = true,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                Message = "Want to learn? Well read some of our History books",
                Title = "Book worm",
                Price = 45,
            });
            subscriptions.Add(new PubHubSubscription
            {
                SubscriptionID = subscriptionIDs[3],
                Active = true,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2),
                Message = "My colliction of books i need for school",
                Title = "School books",
                Price = 49.95,
            });

            foreach (PubHubSubscription subscription in subscriptions)
            {
                builder.Entity<PubHubSubscription>().HasData(subscription);
            }

            #endregion

            #region Relationships Creation

            #region Add Books to Publishers
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[0].EBookID,
                PubHubPublisherPublisherID = publishers[0].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[1].EBookID,
                PubHubPublisherPublisherID = publishers[0].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[3].EBookID,
                PubHubPublisherPublisherID = publishers[0].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[4].EBookID,
                PubHubPublisherPublisherID = publishers[1].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[5].EBookID,
                PubHubPublisherPublisherID = publishers[1].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[6].EBookID,
                PubHubPublisherPublisherID = publishers[1].PublisherID
            });
            builder.Entity<PubHubEBookPubHubPublisher>().HasData(new PubHubEBookPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[7].EBookID,
                PubHubPublisherPublisherID = publishers[1].PublisherID
            });
            #endregion

            #region Add Books to Readers
            builder.Entity<PubHubEBookPubHubReader>().HasData(new PubHubEBookPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[4].EBookID,
                PubHubReaderReaderID = readers[0].ReaderID
            });
            builder.Entity<PubHubEBookPubHubReader>().HasData(new PubHubEBookPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[5].EBookID,
                PubHubReaderReaderID = readers[0].ReaderID
            });
            builder.Entity<PubHubEBookPubHubReader>().HasData(new PubHubEBookPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[6].EBookID,
                PubHubReaderReaderID = readers[1].ReaderID
            });
            builder.Entity<PubHubEBookPubHubReader>().HasData(new PubHubEBookPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[5].EBookID,
                PubHubReaderReaderID = readers[1].ReaderID
            });
            builder.Entity<PubHubEBookPubHubReader>().HasData(new PubHubEBookPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[2].EBookID,
                PubHubReaderReaderID = readers[1].ReaderID
            });
            #endregion

            #region Add subscription to Publisher
            builder.Entity<PubHubSupscriptionPubHubPublisher>().HasData(new PubHubSupscriptionPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubSubscriptionSubscriptionID = subscriptions[0].SubscriptionID,
                PubHubPublisherPublisherID = publishers[0].PublisherID
            });
            builder.Entity<PubHubSupscriptionPubHubPublisher>().HasData(new PubHubSupscriptionPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubSubscriptionSubscriptionID = subscriptions[2].SubscriptionID,
                PubHubPublisherPublisherID = publishers[0].PublisherID
            });
            builder.Entity<PubHubSupscriptionPubHubPublisher>().HasData(new PubHubSupscriptionPubHubPublisher
            {
                ID = Guid.NewGuid(),
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID,
                PubHubPublisherPublisherID = publishers[1].PublisherID
            });
            #endregion

            #region Add Romance books to subscription
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[1].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[0].SubscriptionID
            });
            #endregion

            #region Add History books to subscription
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[2].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[2].SubscriptionID
            });
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[0].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[2].SubscriptionID
            });
            #endregion

            #region Add Fantasy-Thriller-Adventure books to subscription
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[3].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID
            });
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[4].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID
            });
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[5].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID
            });
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[6].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID
            });
            builder.Entity<PubHubEBookPubHubSubscription>().HasData(new PubHubEBookPubHubSubscription
            {
                ID = Guid.NewGuid(),
                PubHubEBookEBookID = books[7].EBookID,
                PubHubSubscriptionSubscriptionID = subscriptions[1].SubscriptionID
            });
            #endregion

            #region Add Custom subscription to reader

            builder.Entity<PubHubSubscriptionPubHubReader>().HasData(new PubHubSubscriptionPubHubReader
            {
                ID = Guid.NewGuid(),
                PubHubSubscriptionSubscriptionID = subscriptions[3].SubscriptionID,
                PubHubReaderReaderID = readers[1].ReaderID
            });

            #endregion

            #endregion
        }
        internal List<Guid> GetRandomGuids(int amount)
        {
            try
            {
                List<Guid> temp = new List<Guid>();
                for (int i = 0; i < amount; i++)
                {
                    temp.Add(Guid.NewGuid());
                }
                return temp;
            }
            catch (Exception ex)
            {
                return new List<Guid>();
            }
        }
    }
}
