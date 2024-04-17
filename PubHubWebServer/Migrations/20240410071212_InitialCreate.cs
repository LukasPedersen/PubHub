using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                name: "SubscriptionPublishers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubPublisherPublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPublishers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubscriptionPublishers_Publishers_PubHubPublisherPublisherID",
                        column: x => x.PubHubPublisherPublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubscriptionPublishers_Subscriptions_PubHubSubscriptionSubscriptionID",
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
                name: "SubscriptionReaders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PubHubReaderReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionReaders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubscriptionReaders_Readers_PubHubReaderReaderID",
                        column: x => x.PubHubReaderReaderID,
                        principalTable: "Readers",
                        principalColumn: "ReaderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubscriptionReaders_Subscriptions_PubHubSubscriptionSubscriptionID",
                        column: x => x.PubHubSubscriptionSubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApplicationUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", null, "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", "Reader", "READER" },
                    { "9442baa8-756a-4c8c-bff2-122126d10ea9", null, "9442baa8-756a-4c8c-bff2-122126d10ea9", "Admin", "ADMIN" },
                    { "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", null, "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", "Publisher", "PUBLISHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "063a2e71-c5c3-490a-8731-d08e25ca43c9", 0, true, "f079f3a8-00ea-4351-b24e-ffe2d4f315b8", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("ce3e6fa0-d2d3-48b8-82bc-7847f0198959"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAd709Z+VYZr3+d3NWWaPqF7vjbXj139nJdUu1jeKaJ9jmzTHf0jVqLD1dVtaUyoIg==", null, false, "2f3519cb-fce4-47e4-91eb-dd9241c3306f", false, "lukas3302@hotmail.com" },
                    { "1edb2bf3-4c3d-4b94-8d0c-3a18dc159fcd", 0, true, "5bc25488-20dd-4f21-a2dc-5e24319d3266", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFAKxjeJt980YAMDs8pKC8z5ZrWCK7X+dRey0nI9GTRIwaBTSVBa/3QpilehhT5o9w==", null, false, "9017b4b7-ef7b-4ff0-8fce-0a59eb756a8a", false, "Mellemgaard@hotmail.com" },
                    { "29edea6b-5e1a-48d9-bf42-d52572e49ef4", 0, true, "31a4be4d-9cc6-43a1-85d8-bae33227db3a", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAENdgMf6tClaHchik0977A2wobpMT76B8DM0Mr/n2CkbUS0V8Hka3rVW2XeZCmPbPtQ==", null, false, "99b505d5-aafb-42c1-8d90-9ff7e82dfc88", false, "ens2837@hotmail.com" },
                    { "84f5ddc8-55dc-4d4e-9b06-b263bde5305c", 0, true, "a9012ec0-71ee-40c5-896f-d8268ec120ae", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("8848bded-4306-4443-9962-d8e84ae802ef"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIHDKHy+OeVi4sTeMkYQvfW5iyEpz7UjQ4fQHhMLJAf/r1CJ20HqluTbJFhxTe5xUg==", null, false, "3417b1cb-4637-4ff8-a7d7-fd94d1b76289", false, "Nordic@hotmail.com" },
                    { "f9121407-b145-4cfe-a970-3f23e946e292", 0, true, "805de01b-4323-4a91-9e20-0438e6f3ec85", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJyiSv1/Y+jQXtyqvtsruXmvxA7qlXkW7kxXekNR4Jc2nVwZdzeMjcJbhB+o6uwGOw==", null, false, "50bbf76b-4a07-450b-bc0d-d12c10560b0b", false, "Admin@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("34630099-f790-46bd-b3a2-ffcbc4098031"), "Gustave Aimard", 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 240, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("37a5c24b-5921-4a0a-bfdc-1a86c7950091"), "Gustave Aimard", 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"), "Gustave Aimard", 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("c339e5e0-3e68-4b02-b4ed-ab2078646234"), "Gustave Aimard", 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("c88b4604-8d86-456f-ac5f-343e194c81f0"), "Gustave Aimard", 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("c8b5140e-6fb4-4a30-8f49-859c7012f45e"), "Charlotte M. Yonge", 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" },
                    { new Guid("c92d3f7c-7443-4590-a408-62777bbf242e"), "Gustave Aimard", 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("d210234b-f17d-4afe-b440-ba78aad861ea"), "Gustave Aimard", 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 574, 19.949999999999999, "The Heir of Redclyffe" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a"), true, new DateTime(2024, 5, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5303), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5299), "Fantasy Hype" },
                    { new Guid("5b63a52e-e1e5-4f99-8899-d3d12b6e879d"), true, new DateTime(2024, 5, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5258), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5083), "Romance Mounth" },
                    { new Guid("7a2eb4f8-b060-4f8c-af4f-9ff0a4ea464a"), true, new DateTime(2024, 6, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5474), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5469), "School books" },
                    { new Guid("a03646e1-cef6-4c8b-b324-1289ee2caeb8"), true, new DateTime(2024, 5, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5453), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 10, 9, 12, 10, 834, DateTimeKind.Local).AddTicks(5430), "Book worm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", "063a2e71-c5c3-490a-8731-d08e25ca43c9" },
                    { "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", "1edb2bf3-4c3d-4b94-8d0c-3a18dc159fcd" },
                    { "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", "29edea6b-5e1a-48d9-bf42-d52572e49ef4" },
                    { "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", "84f5ddc8-55dc-4d4e-9b06-b263bde5305c" },
                    { "9442baa8-756a-4c8c-bff2-122126d10ea9", "f9121407-b145-4cfe-a970-3f23e946e292" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("10520693-a97b-4e42-9f02-9693912ebc75"), new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") },
                    { new Guid("3c45f386-feb5-4415-b54f-54f2803a809f"), new Guid("c8b5140e-6fb4-4a30-8f49-859c7012f45e"), new Guid("a03646e1-cef6-4c8b-b324-1289ee2caeb8") },
                    { new Guid("3e9a790f-5ee2-40dc-a6cf-000ea797d1b2"), new Guid("c339e5e0-3e68-4b02-b4ed-ab2078646234"), new Guid("5b63a52e-e1e5-4f99-8899-d3d12b6e879d") },
                    { new Guid("747e8919-ed74-4185-b905-79c392bcb485"), new Guid("34630099-f790-46bd-b3a2-ffcbc4098031"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") },
                    { new Guid("95d0905f-406e-4ebd-905d-f408e1cc4a9e"), new Guid("c88b4604-8d86-456f-ac5f-343e194c81f0"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") },
                    { new Guid("a0879660-ceca-430a-ba53-5afd83b06a21"), new Guid("37a5c24b-5921-4a0a-bfdc-1a86c7950091"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") },
                    { new Guid("b63fe173-1463-469b-8dd6-5c0d8198939b"), new Guid("c92d3f7c-7443-4590-a408-62777bbf242e"), new Guid("a03646e1-cef6-4c8b-b324-1289ee2caeb8") },
                    { new Guid("d304700d-5f7f-495d-a6f5-1d5cce5f9dd4"), new Guid("d210234b-f17d-4afe-b440-ba78aad861ea"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe"), "1edb2bf3-4c3d-4b94-8d0c-3a18dc159fcd", "Forlaget Mellemgaard" },
                    { new Guid("8848bded-4306-4443-9962-d8e84ae802ef"), "84f5ddc8-55dc-4d4e-9b06-b263bde5305c", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14"), "29edea6b-5e1a-48d9-bf42-d52572e49ef4" },
                    { new Guid("ce3e6fa0-d2d3-48b8-82bc-7847f0198959"), "063a2e71-c5c3-490a-8731-d08e25ca43c9" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("08d54c14-b0e0-4ac1-9419-ca1e7b098444"), new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"), new Guid("8848bded-4306-4443-9962-d8e84ae802ef") },
                    { new Guid("10e1f648-739b-4520-aae3-02aa966dd721"), new Guid("c339e5e0-3e68-4b02-b4ed-ab2078646234"), new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe") },
                    { new Guid("4d0299fe-9c4e-445a-bd38-f750412ef874"), new Guid("34630099-f790-46bd-b3a2-ffcbc4098031"), new Guid("8848bded-4306-4443-9962-d8e84ae802ef") },
                    { new Guid("5fe56dae-3eb3-48db-bc0c-a9cfad8188b6"), new Guid("c88b4604-8d86-456f-ac5f-343e194c81f0"), new Guid("8848bded-4306-4443-9962-d8e84ae802ef") },
                    { new Guid("7a4438b6-bccf-481b-87d8-342426bf1d8e"), new Guid("c8b5140e-6fb4-4a30-8f49-859c7012f45e"), new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe") },
                    { new Guid("905b3e6d-9415-41e7-829d-392efae0a8df"), new Guid("d210234b-f17d-4afe-b440-ba78aad861ea"), new Guid("8848bded-4306-4443-9962-d8e84ae802ef") },
                    { new Guid("bc3c5b75-3089-4a43-bcad-ebe20f1ea3d8"), new Guid("37a5c24b-5921-4a0a-bfdc-1a86c7950091"), new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("816242e5-6633-4428-9cf1-31a2b497c672"), new Guid("c88b4604-8d86-456f-ac5f-343e194c81f0"), new Guid("ce3e6fa0-d2d3-48b8-82bc-7847f0198959") },
                    { new Guid("a7283004-ba59-493a-aa23-bab3d73b9117"), new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"), new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14") },
                    { new Guid("bac4aa3b-9a0e-4f11-8f57-9c62cb9be626"), new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"), new Guid("ce3e6fa0-d2d3-48b8-82bc-7847f0198959") },
                    { new Guid("d5a795ac-a51c-4010-a50d-f53f81851935"), new Guid("d210234b-f17d-4afe-b440-ba78aad861ea"), new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14") },
                    { new Guid("e02c6357-4580-492b-9d05-675bdb807ceb"), new Guid("c92d3f7c-7443-4590-a408-62777bbf242e"), new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("999632dc-9e92-48ed-970b-2d442c956e14"), new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe"), new Guid("5b63a52e-e1e5-4f99-8899-d3d12b6e879d") },
                    { new Guid("a7d23c05-cf52-4bd0-8afe-7deab009bb96"), new Guid("8848bded-4306-4443-9962-d8e84ae802ef"), new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a") },
                    { new Guid("b2747f3e-c2ee-478f-9b08-5a34ee8a5d54"), new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe"), new Guid("a03646e1-cef6-4c8b-b324-1289ee2caeb8") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("4e0e24de-d69d-48aa-a215-d40dadc45052"), new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14"), new Guid("7a2eb4f8-b060-4f8c-af4f-9ff0a4ea464a") });

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
                name: "IX_Publishers_ApplicationUserId",
                table: "Publishers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Readers_ApplicationUserId",
                table: "Readers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPublishers_PubHubPublisherPublisherID",
                table: "SubscriptionPublishers",
                column: "PubHubPublisherPublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPublishers_PubHubSubscriptionSubscriptionID",
                table: "SubscriptionPublishers",
                column: "PubHubSubscriptionSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionReaders_PubHubReaderReaderID",
                table: "SubscriptionReaders",
                column: "PubHubReaderReaderID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionReaders_PubHubSubscriptionSubscriptionID",
                table: "SubscriptionReaders",
                column: "PubHubSubscriptionSubscriptionID");
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
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "SubscriptionPublishers");

            migrationBuilder.DropTable(
                name: "SubscriptionReaders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EBooks");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Readers");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
