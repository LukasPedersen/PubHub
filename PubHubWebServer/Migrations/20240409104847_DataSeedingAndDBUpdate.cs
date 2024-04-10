using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingAndDBUpdate : Migration
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ApplicationUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13a960dc-e6b1-4d16-ae95-8ba69138d534", null, "13a960dc-e6b1-4d16-ae95-8ba69138d534", "Admin", "ADMIN" },
                    { "3408f804-1ec4-4ae4-aa7d-2eafa6aec4f3", null, "3408f804-1ec4-4ae4-aa7d-2eafa6aec4f3", "Publisher", "PUBLISHER" },
                    { "dd36f81d-39d6-4111-a03f-f4b7a4b88221", null, "dd36f81d-39d6-4111-a03f-f4b7a4b88221", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04e27f18-08ac-41be-b6c8-8be2218036cc", 0, true, "fe6d4840-b83a-426f-b26d-0cd5f5140966", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("1a1d626a-3a33-46c9-9597-5519ed44a8eb"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAENMDg7Ian38TDD0bPZnrmip3vTHYc7c4K+qOWmdo1pJVEKAjwhKtiDBnaMlWZKpybw==", null, false, "06aefc96-e0ce-4fe6-b7a8-2ee1bd0e145b", false, "lukas3302@hotmail.com" },
                    { "65399a4e-3334-40d6-95e5-eafcc89f280e", 0, true, "9960f6ed-a83e-495b-ab3a-6a2b0ba73c40", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP2NQem7wZRHW5YA1P6gRlmyT4n1Uhcg4UfNp9K/qgrzUSRUI8zhUheHNkBLqp7NlQ==", null, false, "7ea4c94d-51b9-4258-b6a0-463ff2ba07ea", false, "Mellemgaard@hotmail.com" },
                    { "a90b0379-0b57-41b4-8ac1-2e7afe156243", 0, true, "f84e7f36-d045-4083-ad3a-8e1caea33cd6", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMEMAlvxqjEFo7/9wLw2yG7vH/KY6v16fhY/qT28+XmhSWBd9HkcKpO0ZMDpwSaZng==", null, false, "09bb9379-1ba9-42e7-8326-b5b9a2ba5b83", false, "Admin@hotmail.com" },
                    { "c53c25b8-a604-4bcd-a2fb-86ed379ed124", 0, true, "4c744d18-3d91-483a-93e1-cdd1a5afb53f", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("81909497-ac47-4b00-855f-63af580fa33e"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFweEK8IRJU38M0KPUsIKnENR2tCu/wW0gwbQ+TwrmccoA64iZt2tilCvt1wf3jXWw==", null, false, "2d5374b7-4d86-4b09-a340-def1d917270d", false, "Nordic@hotmail.com" },
                    { "f0bc89f5-bad1-456d-a14b-a116b6fd4e4f", 0, true, "5e616355-7994-4184-a19d-008a0ed6a87a", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAECfUDbvVVBHk9kvki+Yr/vcrZSkhzTPXzBP+fHsM6lL6KeEtqVr3XOKC6Oeaeb/SQQ==", null, false, "211051f6-f6af-4f65-ad59-068aea1f12df", false, "ens2837@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("06192ae7-e2e5-48b2-88e4-83d5eb6172ed"), "Gustave Aimard", 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("3004ebcd-db5f-46ac-9824-e407c1323a3b"), "Gustave Aimard", 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("63495020-4f98-486e-a2c3-e1a519efc2a7"), "Gustave Aimard", 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("77686024-6631-4b3c-b178-73ad0e043681"), "Gustave Aimard", 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("ccf37921-d926-4868-86b2-ac99ef37f44e"), "Gustave Aimard", 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("d5bf8f51-d10d-4af3-bc75-4a59c7105a17"), "Charlotte M. Yonge", 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" },
                    { new Guid("f0887fa1-0569-45df-b6fa-588d894bd54f"), "Gustave Aimard", 43.0, "Opening with loading a ship in Cape Horn, Chile, the book takes readers on an adventure throughout South America. Encounters with indigenous populations and learning to find common ground with others are at the heart of this tale, in many ways mirroring the author's own experiences.", 0L, "", "Fiction Adventure", 190, 206.94999999999999, "The Guide of the Desert" },
                    { new Guid("f2d06bc4-19b8-4337-a6a5-8efae669fc9f"), "Gustave Aimard", 89.950000000000003, "\"The Flying Horseman\" is a thrilling tale penned by the French writer Gustave Aimard. Set in a world of adventure and danger, the story follows the journey of its titular character as he navigates challenges and confronts adversaries. With its gripping narrative and rich character development, this classic work is a testament to Aimard's literary genius.", 0L, "", "Thriller French Adventure", 166, 299.94999999999999, "The Flying Horseman" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("8673115c-f664-4de4-ab79-22a1181f0a84"), true, new DateTime(2024, 6, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(880), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(877), "School books" },
                    { new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c"), true, new DateTime(2024, 5, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(852), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(850), "Fantasy Hype" },
                    { new Guid("9bd7be82-0c16-4270-91cf-3fd73ea08b73"), true, new DateTime(2024, 5, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(867), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(856), "Book worm" },
                    { new Guid("ba1fc5fe-8ae8-4b7e-b260-de422aab3f3b"), true, new DateTime(2024, 5, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(829), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 9, 12, 48, 47, 175, DateTimeKind.Local).AddTicks(708), "Romance Mounth" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dd36f81d-39d6-4111-a03f-f4b7a4b88221", "04e27f18-08ac-41be-b6c8-8be2218036cc" },
                    { "3408f804-1ec4-4ae4-aa7d-2eafa6aec4f3", "65399a4e-3334-40d6-95e5-eafcc89f280e" },
                    { "13a960dc-e6b1-4d16-ae95-8ba69138d534", "a90b0379-0b57-41b4-8ac1-2e7afe156243" },
                    { "3408f804-1ec4-4ae4-aa7d-2eafa6aec4f3", "c53c25b8-a604-4bcd-a2fb-86ed379ed124" },
                    { "dd36f81d-39d6-4111-a03f-f4b7a4b88221", "f0bc89f5-bad1-456d-a14b-a116b6fd4e4f" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("099fd5f5-cad1-4b90-84bc-9fdc2d92cdd0"), new Guid("d5bf8f51-d10d-4af3-bc75-4a59c7105a17"), new Guid("9bd7be82-0c16-4270-91cf-3fd73ea08b73") },
                    { new Guid("431f8d8d-85e7-446b-947d-aa6464512684"), new Guid("77686024-6631-4b3c-b178-73ad0e043681"), new Guid("ba1fc5fe-8ae8-4b7e-b260-de422aab3f3b") },
                    { new Guid("4a735e10-f4ef-4e4b-8157-8cfaab2ff6d0"), new Guid("f2d06bc4-19b8-4337-a6a5-8efae669fc9f"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") },
                    { new Guid("894a76eb-15a4-4019-a262-d75be3e473be"), new Guid("63495020-4f98-486e-a2c3-e1a519efc2a7"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") },
                    { new Guid("9c100023-2b26-479c-8e48-28bd8c6a92d0"), new Guid("06192ae7-e2e5-48b2-88e4-83d5eb6172ed"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") },
                    { new Guid("b263b741-8072-454f-97ff-c1a8681f6a1d"), new Guid("3004ebcd-db5f-46ac-9824-e407c1323a3b"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") },
                    { new Guid("e2f01950-fac0-45bb-bd5e-25537f127346"), new Guid("ccf37921-d926-4868-86b2-ac99ef37f44e"), new Guid("9bd7be82-0c16-4270-91cf-3fd73ea08b73") },
                    { new Guid("e8a8c35e-c7b6-46cd-bd5c-88c8fd18eb77"), new Guid("f0887fa1-0569-45df-b6fa-588d894bd54f"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0"), "65399a4e-3334-40d6-95e5-eafcc89f280e", "Forlaget Mellemgaard" },
                    { new Guid("81909497-ac47-4b00-855f-63af580fa33e"), "c53c25b8-a604-4bcd-a2fb-86ed379ed124", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("1a1d626a-3a33-46c9-9597-5519ed44a8eb"), "04e27f18-08ac-41be-b6c8-8be2218036cc" },
                    { new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5"), "f0bc89f5-bad1-456d-a14b-a116b6fd4e4f" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("2a443ccb-8a99-4872-9e7b-4df1220be3e5"), new Guid("06192ae7-e2e5-48b2-88e4-83d5eb6172ed"), new Guid("81909497-ac47-4b00-855f-63af580fa33e") },
                    { new Guid("4504c299-93bb-4fb9-ac2c-6b2a333f13c1"), new Guid("3004ebcd-db5f-46ac-9824-e407c1323a3b"), new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0") },
                    { new Guid("4a21a75a-8470-4650-972d-9a009d9d7908"), new Guid("63495020-4f98-486e-a2c3-e1a519efc2a7"), new Guid("81909497-ac47-4b00-855f-63af580fa33e") },
                    { new Guid("5445f019-62a8-4347-9a92-73503d9bba15"), new Guid("77686024-6631-4b3c-b178-73ad0e043681"), new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0") },
                    { new Guid("5c5501d2-e83b-4c47-90fd-1c7d1257b225"), new Guid("f0887fa1-0569-45df-b6fa-588d894bd54f"), new Guid("81909497-ac47-4b00-855f-63af580fa33e") },
                    { new Guid("5d7ca24f-126c-4746-9b17-8de35cd1734d"), new Guid("f2d06bc4-19b8-4337-a6a5-8efae669fc9f"), new Guid("81909497-ac47-4b00-855f-63af580fa33e") },
                    { new Guid("a7eaebce-53b5-437c-9911-5f0a285f6174"), new Guid("d5bf8f51-d10d-4af3-bc75-4a59c7105a17"), new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("15e95d7b-7426-4aa5-aa0d-1c12bb884c74"), new Guid("ccf37921-d926-4868-86b2-ac99ef37f44e"), new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5") },
                    { new Guid("3804662a-5a8e-4567-ae7b-36d6dcad8d65"), new Guid("06192ae7-e2e5-48b2-88e4-83d5eb6172ed"), new Guid("1a1d626a-3a33-46c9-9597-5519ed44a8eb") },
                    { new Guid("67014d43-878d-47bb-a0bf-0a7533cc0b0a"), new Guid("63495020-4f98-486e-a2c3-e1a519efc2a7"), new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5") },
                    { new Guid("96f54c79-c82b-407d-b8ba-d47f495f6257"), new Guid("f2d06bc4-19b8-4337-a6a5-8efae669fc9f"), new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5") },
                    { new Guid("f9022d44-fe69-4ae4-86a0-1325e34333ad"), new Guid("63495020-4f98-486e-a2c3-e1a519efc2a7"), new Guid("1a1d626a-3a33-46c9-9597-5519ed44a8eb") }
                });

            migrationBuilder.InsertData(
                table: "PubHubSubscriptionPubHubReader",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("156a10dc-f38b-4b7a-82b6-4731098b2125"), new Guid("61f79e0f-e70f-4ab3-bb69-46c318c8d8d5"), new Guid("8673115c-f664-4de4-ab79-22a1181f0a84") });

            migrationBuilder.InsertData(
                table: "PubHubSupscriptionPubHubPublisher",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("55aac2da-822d-43ef-8c29-2b1f38ef3598"), new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0"), new Guid("ba1fc5fe-8ae8-4b7e-b260-de422aab3f3b") },
                    { new Guid("7d2b0ce4-aa2c-4501-bd4b-25b013ca78e2"), new Guid("6e8a402d-6569-4a0d-8a42-b4a5c037cdb0"), new Guid("9bd7be82-0c16-4270-91cf-3fd73ea08b73") },
                    { new Guid("e4076518-d02b-4c67-9ecb-e20811dda146"), new Guid("81909497-ac47-4b00-855f-63af580fa33e"), new Guid("9072ef40-ac3f-4e85-b5dd-aa7f9ba75b6c") }
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
