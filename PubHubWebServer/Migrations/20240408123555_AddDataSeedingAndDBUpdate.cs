using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeedingAndDBUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MyPubHubAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EBooks",
                columns: table => new
                {
                    EBookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadCount = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BorrowPrice = table.Column<double>(type: "float", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBooks", x => x.EBookID);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LogType = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    ReceiptID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acquired = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.ReceiptID);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                    table.ForeignKey(
                        name: "FK_Publishers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Readers",
                columns: table => new
                {
                    ReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readers", x => x.ReaderID);
                    table.ForeignKey(
                        name: "FK_Readers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EBookSubscriptions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubEBookEBookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookSubscriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EBookSubscriptions_EBooks_PubHubEBookEBookID",
                        column: x => x.PubHubEBookEBookID,
                        principalTable: "EBooks",
                        principalColumn: "EBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EBookSubscriptions_Subscriptions_PubHubSubscriptionSubscriptionID",
                        column: x => x.PubHubSubscriptionSubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EBookPublishers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubEBookEBookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubPublisherPublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookPublishers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EBookPublishers_EBooks_PubHubEBookEBookID",
                        column: x => x.PubHubEBookEBookID,
                        principalTable: "EBooks",
                        principalColumn: "EBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EBookPublishers_Publishers_PubHubPublisherPublisherID",
                        column: x => x.PubHubPublisherPublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PubHubSupscriptionPubHubPublisher",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubPublisherPublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PubHubSupscriptionPubHubPublisher", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PubHubSupscriptionPubHubPublisher_Publishers_PubHubPublisherPublisherID",
                        column: x => x.PubHubPublisherPublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PubHubSupscriptionPubHubPublisher_Subscriptions_PubHubSubscriptionSubscriptionID",
                        column: x => x.PubHubSubscriptionSubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EBookReaders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubEBookEBookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubReaderReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookReaders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EBookReaders_EBooks_PubHubEBookEBookID",
                        column: x => x.PubHubEBookEBookID,
                        principalTable: "EBooks",
                        principalColumn: "EBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EBookReaders_Readers_PubHubReaderReaderID",
                        column: x => x.PubHubReaderReaderID,
                        principalTable: "Readers",
                        principalColumn: "ReaderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PubHubSubscriptionPubHubReader",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubReaderReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PubHubSubscriptionPubHubReader", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PubHubSubscriptionPubHubReader_Readers_PubHubReaderReaderID",
                        column: x => x.PubHubReaderReaderID,
                        principalTable: "Readers",
                        principalColumn: "ReaderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PubHubSubscriptionPubHubReader_Subscriptions_PubHubSubscriptionSubscriptionID",
                        column: x => x.PubHubSubscriptionSubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01ff729e-ded4-4d3b-a7c4-5c548fa3e990", 0, true, "9b8fdbf6-ed5a-4b82-aaf4-dd4d5e080d52", "ApplicationUser", "Mellemgaard@hotmail.com", false, false, null, new Guid("052eb16b-a255-44d7-b420-febe6518bf82"), "MELLEMGAARD@HOTMAIL.COM", "FORLAGET MELLEMGAARD", "AQAAAAIAAYagAAAAEEmqQe/vndhXqRlDxRsxGHAX1kuWQ117TY6XF/XEO905889tcX+x5AeDq4eyXySWEQ==", null, false, "TBBRBHXVDKL4JYRX5YZLFTX56P76CYKO", false, "Forlaget Mellemgaard" },
                    { "0f129464-655f-42c9-95bd-2f81a49f61d8", 0, true, "d317d42c-6ab7-4ece-b9c4-4210d3c2f009", "ApplicationUser", "Jens2837@hotmail.com", false, false, null, new Guid("55404489-9476-4b98-8311-2903bc4d79ab"), "JENS2837@HOTMAIL.COM", "JENS ANKER", "AQAAAAIAAYagAAAAEH5hcJHlyO7YeqMGmZqDju46u5EHka/NiKKqqJHKpbq3jEiI5UT1tsVlUp4ziDa+5Q==", null, false, "FT4UX4Y6TUBDTMWYUAIVE622QJ6GHBOG", false, "Jens Anker" },
                    { "109af2b7-2e0b-4149-9473-9795a2f97c2f", 0, true, "a4d4b000-df14-4c3e-9f89-73a90c4a8584", "ApplicationUser", "Admin@hotmail.com", false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEI7YCzKIQOnqgMycVwCJ/45d4njC5tjma1AFeC1Z/YuJ2ZD91x+B90FvXluwB3qZvw==", null, false, "GP4QLQ2ZVJJBYBHBQLLGP4G22UJJFH4U", false, "Admin" },
                    { "986bd8a5-0db6-4d89-8f23-7ead94377515", 0, true, "653cb2db-6f92-4eda-8288-ec972843ad9d", "ApplicationUser", "Nordic@hotmail.com", false, false, null, new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53"), "NORDIC@HOTMAIL.COM", "BUSTER NORDIC", "AQAAAAIAAYagAAAAEKpF63VYci9tx6jT7M6RwfqLpgvmA5W8iFFOyOVJZsXZ+5ozXHv+vVhSZ4iBWDHRDA==", null, false, "NQUEGF4VUUD7QGUA4XP5YNMDMLT5US6H", false, "Buster Nordic" },
                    { "ccc1a851-144d-488f-9a1b-2005aec95e36", 0, true, "e82c37ba-22be-4f0a-ac8b-23a62c11476a", "ApplicationUser", "lukas3302@hotmail.com", false, false, null, new Guid("6dbbafaf-5ec7-413d-b03e-fc7b40fc7e79"), "LUKAS3302@HOTMAIL.COM", "LUKAS", "AQAAAAIAAYagAAAAEPsl/YnmLOop8Q3eHEXfKy0CTTI7Vpm2pWEn64idVqozxtLVvtcr4Uf1iyRbshmsIw==", null, false, "GLY234PA27LVMGEQEBJERG7KGRXQSRDU", false, "Lukas Pedersen" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("19c64e6d-427b-4932-a59d-33cc2a16a31d"), "Charlotte M. Yonge", 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" },
                    { new Guid("4e44afc3-ac55-4dcf-8982-f0f6381d47c7"), "Gustave Aimard", 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("5064fa5d-f6b7-4cc8-9c69-cba0f86ede99"), "Gustave Aimard", 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("56a12b8e-bcc9-465d-84e0-087bb4d1e0f3"), "Gustave Aimard", 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("5ac87ad1-97ae-4fca-be7c-5c055feb028d"), "Gustave Aimard", 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("9a295882-ea44-40e8-93bd-0e5aa28de707"), "Gustave Aimard", 89.950000000000003, "\"The Flying Horseman\" is a thrilling tale penned by the French writer Gustave Aimard. Set in a world of adventure and danger, the story follows the journey of its titular character as he navigates challenges and confronts adversaries. With its gripping narrative and rich character development, this classic work is a testament to Aimard's literary genius.", 0L, "", "Thriller French Adventure", 166, 299.94999999999999, "The Flying Horseman" },
                    { new Guid("a4e7f328-bc06-4f8e-8e8d-0f1a5b1b2884"), "Gustave Aimard", 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("a5ed762d-75fd-4692-a23c-e74053bbe11c"), "Gustave Aimard", 43.0, "Opening with loading a ship in Cape Horn, Chile, the book takes readers on an adventure throughout South America. Encounters with indigenous populations and learning to find common ground with others are at the heart of this tale, in many ways mirroring the author's own experiences.", 0L, "", "Fiction Adventure", 190, 206.94999999999999, "The Guide of the Desert" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("045155fe-a280-4f26-a4d3-724714dfd8df"), true, new DateTime(2024, 5, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9073), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9070), "Book worm" },
                    { new Guid("500b04f5-8690-4c14-9324-7617fac74e7d"), true, new DateTime(2024, 6, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9083), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9080), "School books" },
                    { new Guid("994a9994-e3bd-4c5d-9b1a-ed669595f6e8"), true, new DateTime(2024, 5, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9042), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(8977), "Romance Mounth" },
                    { new Guid("c657c3e9-041b-4c87-b431-d06c7415448e"), true, new DateTime(2024, 5, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9064), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 8, 14, 35, 54, 670, DateTimeKind.Local).AddTicks(9060), "Fantasy Hype" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("1b1985ee-d677-4059-b540-16a63f0c457c"), new Guid("a5ed762d-75fd-4692-a23c-e74053bbe11c"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("1fe178da-54fd-4b46-aaed-9be69e0b27df"), new Guid("19c64e6d-427b-4932-a59d-33cc2a16a31d"), new Guid("045155fe-a280-4f26-a4d3-724714dfd8df") },
                    { new Guid("3dcbbf87-3feb-4078-834f-46899eb2cc69"), new Guid("4e44afc3-ac55-4dcf-8982-f0f6381d47c7"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("450092b0-3e9f-4359-8027-4c67b2f4565d"), new Guid("5064fa5d-f6b7-4cc8-9c69-cba0f86ede99"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("516f581e-2827-469d-a7a7-7f846a5a6bb8"), new Guid("5ac87ad1-97ae-4fca-be7c-5c055feb028d"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("72ea3309-5831-44ac-9b38-8a6f47460286"), new Guid("9a295882-ea44-40e8-93bd-0e5aa28de707"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("8ab8b522-e980-4984-8fbd-40ce9c4766b8"), new Guid("a4e7f328-bc06-4f8e-8e8d-0f1a5b1b2884"), new Guid("045155fe-a280-4f26-a4d3-724714dfd8df") },
                    { new Guid("e176bee1-097d-4089-9c2f-f2d004d12a1a"), new Guid("56a12b8e-bcc9-465d-84e0-087bb4d1e0f3"), new Guid("994a9994-e3bd-4c5d-9b1a-ed669595f6e8") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("052eb16b-a255-44d7-b420-febe6518bf82"), "01ff729e-ded4-4d3b-a7c4-5c548fa3e990", "Forlaget Mellemgaard" },
                    { new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53"), "986bd8a5-0db6-4d89-8f23-7ead94377515", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("55404489-9476-4b98-8311-2903bc4d79ab"), "0f129464-655f-42c9-95bd-2f81a49f61d8" },
                    { new Guid("6dbbafaf-5ec7-413d-b03e-fc7b40fc7e79"), "ccc1a851-144d-488f-9a1b-2005aec95e36" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("1b962b7f-20f3-4d5d-8166-0a62b4c22c93"), new Guid("56a12b8e-bcc9-465d-84e0-087bb4d1e0f3"), new Guid("052eb16b-a255-44d7-b420-febe6518bf82") },
                    { new Guid("2f6eaf43-3a95-44ae-8b39-baa72cee24d4"), new Guid("9a295882-ea44-40e8-93bd-0e5aa28de707"), new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53") },
                    { new Guid("6206ce0f-4862-4c3c-9a6c-73bbf245e11a"), new Guid("19c64e6d-427b-4932-a59d-33cc2a16a31d"), new Guid("052eb16b-a255-44d7-b420-febe6518bf82") },
                    { new Guid("6eb07056-2846-4b8b-a4e9-599c41afba3d"), new Guid("4e44afc3-ac55-4dcf-8982-f0f6381d47c7"), new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53") },
                    { new Guid("a3abc129-5d22-4db4-ae61-a2d32ccb3181"), new Guid("5ac87ad1-97ae-4fca-be7c-5c055feb028d"), new Guid("052eb16b-a255-44d7-b420-febe6518bf82") },
                    { new Guid("af337148-7fcc-470c-8e74-0d40cd3e3e7d"), new Guid("a5ed762d-75fd-4692-a23c-e74053bbe11c"), new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53") },
                    { new Guid("fa1dd5af-82e2-4991-88d2-506fb24b67f5"), new Guid("5064fa5d-f6b7-4cc8-9c69-cba0f86ede99"), new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("219e7589-a189-4561-9894-0a89d5b430e5"), new Guid("9a295882-ea44-40e8-93bd-0e5aa28de707"), new Guid("55404489-9476-4b98-8311-2903bc4d79ab") },
                    { new Guid("26468ed1-4e25-4b18-8fa2-118eb17836b6"), new Guid("5064fa5d-f6b7-4cc8-9c69-cba0f86ede99"), new Guid("6dbbafaf-5ec7-413d-b03e-fc7b40fc7e79") },
                    { new Guid("802a153c-977a-4667-a321-343f7e89cf1e"), new Guid("4e44afc3-ac55-4dcf-8982-f0f6381d47c7"), new Guid("55404489-9476-4b98-8311-2903bc4d79ab") },
                    { new Guid("81666f2e-65a1-4790-adf4-19a9f0953e70"), new Guid("a4e7f328-bc06-4f8e-8e8d-0f1a5b1b2884"), new Guid("55404489-9476-4b98-8311-2903bc4d79ab") },
                    { new Guid("b51f8ff0-c7b6-4e67-bd29-13de66e3eefb"), new Guid("4e44afc3-ac55-4dcf-8982-f0f6381d47c7"), new Guid("6dbbafaf-5ec7-413d-b03e-fc7b40fc7e79") }
                });

            migrationBuilder.InsertData(
                table: "PubHubSubscriptionPubHubReader",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("4c534f9c-b048-484e-b7df-2a022e1ce597"), new Guid("55404489-9476-4b98-8311-2903bc4d79ab"), new Guid("500b04f5-8690-4c14-9324-7617fac74e7d") });

            migrationBuilder.InsertData(
                table: "PubHubSupscriptionPubHubPublisher",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("25a96496-0974-42c9-8fba-ec24591288e1"), new Guid("c2f97cb5-e702-41a1-a1cd-92e2f9decf53"), new Guid("c657c3e9-041b-4c87-b431-d06c7415448e") },
                    { new Guid("279cb752-18a2-4c7c-b82a-6876c25a853a"), new Guid("052eb16b-a255-44d7-b420-febe6518bf82"), new Guid("045155fe-a280-4f26-a4d3-724714dfd8df") },
                    { new Guid("89dddb71-cf7e-459e-8090-32bedb807491"), new Guid("052eb16b-a255-44d7-b420-febe6518bf82"), new Guid("994a9994-e3bd-4c5d-9b1a-ed669595f6e8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                table: "AspNetRoles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EBookPublishers_PubHubEBookEBookID",
                table: "EBookPublishers",
                column: "PubHubEBookEBookID");

            migrationBuilder.CreateIndex(
                name: "IX_EBookPublishers_PubHubPublisherPublisherID",
                table: "EBookPublishers",
                column: "PubHubPublisherPublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_EBookReaders_PubHubEBookEBookID",
                table: "EBookReaders",
                column: "PubHubEBookEBookID");

            migrationBuilder.CreateIndex(
                name: "IX_EBookReaders_PubHubReaderReaderID",
                table: "EBookReaders",
                column: "PubHubReaderReaderID");

            migrationBuilder.CreateIndex(
                name: "IX_EBookSubscriptions_PubHubEBookEBookID",
                table: "EBookSubscriptions",
                column: "PubHubEBookEBookID");

            migrationBuilder.CreateIndex(
                name: "IX_EBookSubscriptions_PubHubSubscriptionSubscriptionID",
                table: "EBookSubscriptions",
                column: "PubHubSubscriptionSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_PubHubSubscriptionPubHubReader_PubHubReaderReaderID",
                table: "PubHubSubscriptionPubHubReader",
                column: "PubHubReaderReaderID");

            migrationBuilder.CreateIndex(
                name: "IX_PubHubSubscriptionPubHubReader_PubHubSubscriptionSubscriptionID",
                table: "PubHubSubscriptionPubHubReader",
                column: "PubHubSubscriptionSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_PubHubSupscriptionPubHubPublisher_PubHubPublisherPublisherID",
                table: "PubHubSupscriptionPubHubPublisher",
                column: "PubHubPublisherPublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_PubHubSupscriptionPubHubPublisher_PubHubSubscriptionSubscriptionID",
                table: "PubHubSupscriptionPubHubPublisher",
                column: "PubHubSubscriptionSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_ApplicationUserId",
                table: "Publishers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Readers_ApplicationUserId",
                table: "Readers",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EBookPublishers");

            migrationBuilder.DropTable(
                name: "EBookReaders");

            migrationBuilder.DropTable(
                name: "EBookSubscriptions");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "PubHubSubscriptionPubHubReader");

            migrationBuilder.DropTable(
                name: "PubHubSupscriptionPubHubPublisher");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EBooks");

            migrationBuilder.DropTable(
                name: "Readers");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
