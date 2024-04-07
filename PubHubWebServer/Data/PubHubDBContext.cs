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
            List<Guid> subscriptionIDs = GetRandomGuids(2);



            #region ApplicationUser Creation

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = applicationUserIDs[0].ToString(),
                    UserName = "Forlaget Mellemgaard",
                    NormalizedUserName = "FORLAGET MELLEMGAARD",
                    Email = "Mellemgaard@hotmail.com",
                    NormalizedEmail = "MELLEMGAARD@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEEmqQe/vndhXqRlDxRsxGHAX1kuWQ117TY6XF/XEO905889tcX+x5AeDq4eyXySWEQ==",
                    SecurityStamp = "TBBRBHXVDKL4JYRX5YZLFTX56P76CYKO",
                    ConcurrencyStamp = "9b8fdbf6-ed5a-4b82-aaf4-dd4d5e080d52",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = publisherIDs[0]
                },
                new ApplicationUser
                {
                    Id = applicationUserIDs[1].ToString(),
                    UserName = "Buster Nordic",
                    NormalizedUserName = "BUSTER NORDIC",
                    Email = "Nordic@hotmail.com",
                    NormalizedEmail = "NORDIC@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEKpF63VYci9tx6jT7M6RwfqLpgvmA5W8iFFOyOVJZsXZ+5ozXHv+vVhSZ4iBWDHRDA==",
                    SecurityStamp = "NQUEGF4VUUD7QGUA4XP5YNMDMLT5US6H",
                    ConcurrencyStamp = "653cb2db-6f92-4eda-8288-ec972843ad9d",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = publisherIDs[1]
                },
                new ApplicationUser
                {
                    Id = applicationUserIDs[2].ToString(),
                    UserName = "Lukas Pedersen",
                    NormalizedUserName = "LUKAS",
                    Email = "lukas3302@hotmail.com",
                    NormalizedEmail = "LUKAS3302@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEPsl/YnmLOop8Q3eHEXfKy0CTTI7Vpm2pWEn64idVqozxtLVvtcr4Uf1iyRbshmsIw==",
                    SecurityStamp = "GLY234PA27LVMGEQEBJERG7KGRXQSRDU",
                    ConcurrencyStamp = "e82c37ba-22be-4f0a-ac8b-23a62c11476a",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = readerIDs[0]
                },
                new ApplicationUser
                {
                    Id = applicationUserIDs[3].ToString(),
                    UserName = "Jens Anker",
                    NormalizedUserName = "JENS ANKER",
                    Email = "Jens2837@hotmail.com",
                    NormalizedEmail = "JENS2837@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEH5hcJHlyO7YeqMGmZqDju46u5EHka/NiKKqqJHKpbq3jEiI5UT1tsVlUp4ziDa+5Q==",
                    SecurityStamp = "FT4UX4Y6TUBDTMWYUAIVE622QJ6GHBOG",
                    ConcurrencyStamp = "d317d42c-6ab7-4ece-b9c4-4210d3c2f009",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                    MyPubHubAccount = readerIDs[1]
                },
                new ApplicationUser
                {
                    Id = applicationUserIDs[4].ToString(),
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "Admin@hotmail.com",
                    NormalizedEmail = "ADMIN@HOTMAIL.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEI7YCzKIQOnqgMycVwCJ/45d4njC5tjma1AFeC1Z/YuJ2ZD91x+B90FvXluwB3qZvw==",
                    SecurityStamp = "GP4QLQ2ZVJJBYBHBQLLGP4G22UJJFH4U",
                    ConcurrencyStamp = "a4d4b000-df14-4c3e-9f89-73a90c4a8584",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    Active = true,
                });

            #endregion

            #region Publisher Creation

            builder.Entity<PubHubPublisher>().HasData(
                new PubHubPublisher
                {
                    PublisherID = publisherIDs[0],
                    ApplicationUserId = applicationUserIDs[0].ToString(),
                    Name = "Forlaget Mellemgaard"
                },
                new PubHubPublisher
                {
                    PublisherID = publisherIDs[1],
                    ApplicationUserId = applicationUserIDs[1].ToString(),
                    Name = "Buster Nordic"
                });

            #endregion

            #region Reader Creation

            builder.Entity<PubHubReader>().HasData(
                new PubHubReader
                {
                    ReaderID = readerIDs[0],
                    ApplicationUserId = applicationUserIDs[2].ToString()
                },
                new PubHubReader
                {
                    ReaderID = readerIDs[1],
                    ApplicationUserId = applicationUserIDs[3].ToString()
                });

            #endregion

            #region Ebooks Creation

            builder.Entity<PubHubEBook>().HasData(
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Little Duke: Richard the Fearless",
                    Description = "Richard I (28 August 933 – 20 November 996), also known as Richard the Fearless (French, Richard Sans-Peur), was the Count of Rouen from 942 to 996. Dudo of Saint-Quentin, whom Richard commissioned to write the \"De moribus et actis primorum Normanniae ducum\" (Latin, \"On the Customs and Deeds of the First Dukes of Normandy\"), called him a Dux.",
                    AuthorNames = "Charlotte M. Yonge",
                    PageCount = 145,
                    Genre = "History",
                    Price = 130.95,
                    BorrowPrice = 65.95,
                    FilePath = "The-Little-Duke-Richard-the-Fearless",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Heir of Redclyffe",
                    Description = "First published in 1853, The Heir of Redclyffe was the most successful novel of the century. Adopted by William Morris and Burne-Jones \"as a pattern for life,\" the protagonist, Guy, was a popular role model of noble virtue, while another character, Amy, was seen as the ideal Victorian wife--redeemer and inspirer, supporter and guide. This novel is a virtual paradigm of the trends of thought which marked the middle decades of the nineteenth-century. It is also deeply marked by the influence of the Oxford Movement, an aspect explored in Barbara Dennis's Introduction to this unique critical edition.",
                    AuthorNames = "Charlotte M. Yonge",
                    PageCount = 637,
                    Genre = "Romance novel",
                    Price = 170,
                    BorrowPrice = 34,
                    FilePath = "The-Heir-of-Redclyffe",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "History of France",
                    Description = "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.",
                    AuthorNames = "Charlotte M. Yonge",
                    PageCount = 78,
                    Genre = "History",
                    Price = 89,
                    BorrowPrice = 21.95,
                    FilePath = "History-of-France",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Pearl of the Andes A Tale of Love and Adventure",
                    Description = "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 205,
                    Genre = "Fantasy Adventure Romance Fiction",
                    Price = 111,
                    BorrowPrice = 45,
                    FilePath = "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Pirates of the Prairies: Adventures in the American Desert",
                    Description = "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 250,
                    Genre = "History",
                    Price = 89.95,
                    BorrowPrice = 27,
                    FilePath = "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Bee Hunters: A Tale of Adventure",
                    Description = "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 240,
                    Genre = "Action Adventure Fiction",
                    Price = 132.95,
                    BorrowPrice = 55,
                    FilePath = "The-Bee-Hunters-A-Tale-of-Adventure",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Smuggler Chief",
                    Description = "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 105,
                    Genre = "Thriller Adventure Fiction",
                    Price = 171,
                    BorrowPrice = 51,
                    FilePath = "The-Smuggler-Chief",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "Las noches mejicanas",
                    Description = "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 240,
                    Genre = "Thriller Adventure Fiction",
                    Price = 159.95,
                    BorrowPrice = 45,
                    FilePath = "Las-noches-mejicanas",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Flying Horseman",
                    Description = "\"The Flying Horseman\" is a thrilling tale penned by the French writer Gustave Aimard. Set in a world of adventure and danger, the story follows the journey of its titular character as he navigates challenges and confronts adversaries. With its gripping narrative and rich character development, this classic work is a testament to Aimard's literary genius.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 166,
                    Genre = "Thriller French Adventure",
                    Price = 299.95,
                    BorrowPrice = 89.95,
                    FilePath = "",
                },
                new PubHubEBook
                {
                    EBookID = Guid.NewGuid(),
                    Title = "The Guide of the Desert",
                    Description = "Opening with loading a ship in Cape Horn, Chile, the book takes readers on an adventure throughout South America. Encounters with indigenous populations and learning to find common ground with others are at the heart of this tale, in many ways mirroring the author's own experiences.",
                    AuthorNames = "Gustave Aimard",
                    PageCount = 190,
                    Genre = "Fiction Adventure",
                    Price = 206.95,
                    BorrowPrice = 43,
                    FilePath = "",
                });
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
