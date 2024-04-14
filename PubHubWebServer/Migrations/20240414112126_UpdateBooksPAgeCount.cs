using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBooksPAgeCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71d3eda2-0069-41cc-9e76-09117bb977cd", "1ea46bde-c4e1-4461-9abd-d1e213364d3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e566e2ec-825a-460b-9753-0d4525021d3a", "1fe12077-ee83-4362-86e4-136d8368b6a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "99dd34ef-a62a-447b-9583-1e1ce6bf7723", "98988cb5-3ede-4f5a-95ab-34569e24290c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71d3eda2-0069-41cc-9e76-09117bb977cd", "b4665254-1122-480e-9473-7a945a0c753e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e566e2ec-825a-460b-9753-0d4525021d3a", "b7e58ae5-8976-401d-8e09-919e59f2266b" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("33a56c83-6f6b-4f44-ad46-9133e89c0ec0"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("3cb443b2-0dc6-4848-b5f0-419e875b2e9d"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("584cd805-6e80-4912-a729-f04c3b7843fd"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("7fa90e95-93f5-4f6f-b20e-dabe8bd7748a"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("8d030ebd-c5c2-41f0-ab3f-39e424217ab1"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("9f2c3c3a-c5b7-4c8a-aefa-1782eac03637"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("b55f6abc-457b-40a0-aae6-ab35bb37dcc8"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("1114142e-8763-4e68-89cf-ab0a9349c123"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("4250dc9b-8908-4044-8011-80444f5e9f36"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("708ae1cd-b7ec-4a30-a120-ad7867e316bd"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("b56ad657-c56b-4b09-af7c-066cb2b9dc91"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("f1aa22be-b260-4b1c-8517-9d587d42f98c"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("54390f5b-3f3d-4d33-882b-759ef95fe3b3"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("7d89a8be-6110-4b7a-bf59-b8d9f46d7d35"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("9cefc482-5442-49ef-804e-83929901c6a1"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("ac9b8d11-d901-4684-98e3-9abbb45b7f28"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("cd8c36b1-d8a1-4fb8-84bb-62572d38dc7c"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("daf5ffe9-9393-4faa-9767-7f274d925bbd"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("e02162c6-be18-4a3f-835e-08333c51d34a"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("f1e5f3cc-355e-4f9f-9973-ca3f380eed3a"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("609a7401-d2f4-4ec4-b020-24f34611853f"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("90d11d08-e86d-4e9c-b7b7-eb0e07463e47"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("d6bd33c2-5d93-4f65-8b59-43231af06c6a"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("d2aa90c7-f798-49e5-8c26-a19bd6b22c8b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d3eda2-0069-41cc-9e76-09117bb977cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99dd34ef-a62a-447b-9583-1e1ce6bf7723");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e566e2ec-825a-460b-9753-0d4525021d3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98988cb5-3ede-4f5a-95ab-34569e24290c");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("4014ab42-199c-4dc2-ae1e-cfb51bf67b65"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("42973c3a-ea90-4411-bb22-f1ac78dece6a"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("49bf65b3-8cdc-4688-b955-7035d1e516b0"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("7fdcff5d-eea6-4f3d-b79c-60b929b4bf38"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("802c8048-63d7-4f2a-8f19-dbfd8207c623"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("88e2d267-89b3-4289-afe3-13cde4b5ee37"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("cfefa5e0-0be9-4a62-b27c-f2058220ba9c"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("aba8c345-3d08-4d90-b64b-fe34d65b9776"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("11fea985-f34a-4167-beed-505643d9d27f"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("26c93320-1dc4-4571-bc12-d5f086a7e4dc"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("83eaede9-0bcb-4e65-b69c-3a87e208d295"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("a9a119ff-82ed-4acf-99be-3afe3519e66d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ea46bde-c4e1-4461-9abd-d1e213364d3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fe12077-ee83-4362-86e4-136d8368b6a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4665254-1122-480e-9473-7a945a0c753e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7e58ae5-8976-401d-8e09-919e59f2266b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApplicationUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "049e7085-70a9-43cb-8321-f89b1e892990", null, "049e7085-70a9-43cb-8321-f89b1e892990", "Admin", "ADMIN" },
                    { "5122c945-fdf0-4b1c-852c-e4d2749b0206", null, "5122c945-fdf0-4b1c-852c-e4d2749b0206", "Reader", "READER" },
                    { "b098240f-15d7-4870-a888-b77a357760bb", null, "b098240f-15d7-4870-a888-b77a357760bb", "Publisher", "PUBLISHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42c2eece-7aae-42af-b8d4-a06a06c641ce", 0, true, "9c132f29-5265-4d4e-8f72-5d37efb6c518", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAELANQFUlhh1ICg6dfKbnGhQofwlhSz8H4qjUfMprfCjdrmimdk2RMUoslxcK+//8mw==", null, false, "e3bf114d-940d-40c6-aa30-352941242113", false, "Mellemgaard@hotmail.com" },
                    { "56526b9d-8b8a-467f-ae44-2fc156eb713b", 0, true, "322c7254-c0fb-420f-a9ea-80386cd811d2", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGr6u78O3dya9eZFQOZpR3GgpIacH/q3HcfuoQnMJo+81H9tntiicjAT5Vb+KFOyYg==", null, false, "63eafe09-168c-4ebe-8322-fadb4f86ea06", false, "Admin@hotmail.com" },
                    { "8c64655b-6d09-42bb-978a-c57d81292c6f", 0, true, "e18580fb-1d40-4d37-803c-d893917fa55b", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI+tR2vfcfTjq5nb6/hlap796tEzJ+KpRFniWSEeCxVM/kO50OnY2yivLF4UNgoFQw==", null, false, "87010c00-85f3-4921-a9f5-2d8dae045a03", false, "Nordic@hotmail.com" },
                    { "92e4891d-6021-4173-b406-1e6ea77652d7", 0, true, "2abfb6d4-5727-47b9-891d-f899fceeadc2", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("e0d50607-63e2-4c7a-8821-6a8c071f229e"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAELsUmXMGtkA/CBhF2ECZDodu0UCUrbcZWNQIPy1cV2xCNysDUyAexy45/txj5iL3Pg==", null, false, "98cbd028-77ae-4bee-a3e3-ac2560a5b923", false, "lukas3302@hotmail.com" },
                    { "bdc70856-bdf4-4f1a-bba0-80cb79f88652", 0, true, "98692953-beb4-4011-9f22-33c032cd6cc2", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAuXeij8hHIaDHM4ip4XdNvsQxcS/0AsJDGgIU5dTnr4X0ApkOzdFYwPet6vIuOQMw==", null, false, "f89315c2-42e4-4218-be1f-560da0882c1e", false, "jens2837@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "Available", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("0c6e718b-76de-4f7f-8996-700f0fb524be"), "Gustave Aimard", true, 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 275, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"), "Gustave Aimard", true, 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 381, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("38505bf9-66f2-4dfb-9c27-ccfee2c22648"), "Gustave Aimard", true, 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 637, 19.949999999999999, "The Heir of Redclyffe" },
                    { new Guid("41f27d0b-7ee6-46ed-be95-9a3af04660cb"), "Charlotte M. Yonge", true, 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 112, 89.0, "History of France" },
                    { new Guid("429e42d7-e8ce-4aff-a270-f73185aa02d6"), "Gustave Aimard", true, 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 275, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("9a3561f8-34b2-4174-9e85-c21cbefc4454"), "Gustave Aimard", true, 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 303.0, "The Smuggler Chief" },
                    { new Guid("f1156230-f5f0-447b-aa5d-c613d0eefa74"), "Gustave Aimard", true, 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("faa3ca9f-28a6-4bb1-88ee-eaad290679b8"), "Gustave Aimard", true, 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 236, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0f951084-f7a7-46c9-9ef5-026555729cff"), true, new DateTime(2024, 5, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7362), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7349), "Book worm" },
                    { new Guid("3f5e3434-9098-49ec-8316-84ec6a143262"), true, new DateTime(2024, 6, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7383), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7378), "School books" },
                    { new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b"), true, new DateTime(2024, 5, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7342), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7337), "Fantasy Hype" },
                    { new Guid("8f315aa2-c1a8-48ad-a9b4-0220e1672aba"), true, new DateTime(2024, 5, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7313), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 14, 13, 21, 24, 989, DateTimeKind.Local).AddTicks(7195), "Romance Mounth" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b098240f-15d7-4870-a888-b77a357760bb", "42c2eece-7aae-42af-b8d4-a06a06c641ce" },
                    { "049e7085-70a9-43cb-8321-f89b1e892990", "56526b9d-8b8a-467f-ae44-2fc156eb713b" },
                    { "b098240f-15d7-4870-a888-b77a357760bb", "8c64655b-6d09-42bb-978a-c57d81292c6f" },
                    { "5122c945-fdf0-4b1c-852c-e4d2749b0206", "92e4891d-6021-4173-b406-1e6ea77652d7" },
                    { "5122c945-fdf0-4b1c-852c-e4d2749b0206", "bdc70856-bdf4-4f1a-bba0-80cb79f88652" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("0d3c22b8-a65c-42b0-be91-e381cd67208f"), new Guid("9a3561f8-34b2-4174-9e85-c21cbefc4454"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("2839ef77-e63e-453c-b4a7-990d545bd8c0"), new Guid("f1156230-f5f0-447b-aa5d-c613d0eefa74"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("4cdf22ae-dd89-4dd4-9d08-cc62e21c0253"), new Guid("38505bf9-66f2-4dfb-9c27-ccfee2c22648"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("6385beeb-6de1-4248-a0dc-c98498f9d241"), new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("7e5fd461-cbb2-4cd6-b3cb-da6d4979c533"), new Guid("429e42d7-e8ce-4aff-a270-f73185aa02d6"), new Guid("8f315aa2-c1a8-48ad-a9b4-0220e1672aba") },
                    { new Guid("99a1904f-d998-4afc-a141-d1b5f44c318c"), new Guid("faa3ca9f-28a6-4bb1-88ee-eaad290679b8"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("e05bd7ad-8ab6-4fd3-a7b0-e152a78ee3f1"), new Guid("41f27d0b-7ee6-46ed-be95-9a3af04660cb"), new Guid("0f951084-f7a7-46c9-9ef5-026555729cff") },
                    { new Guid("e2677d38-9806-4eb4-ba3a-7fd56ede4bd1"), new Guid("0c6e718b-76de-4f7f-8996-700f0fb524be"), new Guid("0f951084-f7a7-46c9-9ef5-026555729cff") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2"), "42c2eece-7aae-42af-b8d4-a06a06c641ce", "Forlaget Mellemgaard" },
                    { new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e"), "8c64655b-6d09-42bb-978a-c57d81292c6f", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83"), "bdc70856-bdf4-4f1a-bba0-80cb79f88652" },
                    { new Guid("e0d50607-63e2-4c7a-8821-6a8c071f229e"), "92e4891d-6021-4173-b406-1e6ea77652d7" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("20d142b1-9d16-499a-8050-00b3d8560b7e"), new Guid("38505bf9-66f2-4dfb-9c27-ccfee2c22648"), new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e") },
                    { new Guid("2c88d1af-50ac-4c04-b576-40839f8b9fc0"), new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"), new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e") },
                    { new Guid("5561dae4-ee6c-4427-bcaa-84e821e8984d"), new Guid("faa3ca9f-28a6-4bb1-88ee-eaad290679b8"), new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e") },
                    { new Guid("6fb2b475-aa10-46c9-a1d0-c612195166f4"), new Guid("41f27d0b-7ee6-46ed-be95-9a3af04660cb"), new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2") },
                    { new Guid("90bd34f8-1529-4768-bfa4-3734b97c8e3d"), new Guid("429e42d7-e8ce-4aff-a270-f73185aa02d6"), new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2") },
                    { new Guid("c17c1165-9105-4028-81f9-6aadf873d3ae"), new Guid("f1156230-f5f0-447b-aa5d-c613d0eefa74"), new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2") },
                    { new Guid("da617c51-f889-4d47-8157-3ac26b77bd8c"), new Guid("9a3561f8-34b2-4174-9e85-c21cbefc4454"), new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("0dc79e73-2967-4b69-9c86-f1e14dd7a4b8"), new Guid("38505bf9-66f2-4dfb-9c27-ccfee2c22648"), new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83") },
                    { new Guid("3dd91c48-4719-448b-ab73-1fa1af51294b"), new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"), new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83") },
                    { new Guid("55722b2e-2bf3-456b-ae9f-29b394a8c90a"), new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"), new Guid("e0d50607-63e2-4c7a-8821-6a8c071f229e") },
                    { new Guid("c22f6237-9bfb-4bc0-8cb4-b64b03f3ca30"), new Guid("0c6e718b-76de-4f7f-8996-700f0fb524be"), new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83") },
                    { new Guid("cc5587ee-dd80-46c4-b99c-1b7c352c5a7a"), new Guid("9a3561f8-34b2-4174-9e85-c21cbefc4454"), new Guid("e0d50607-63e2-4c7a-8821-6a8c071f229e") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("8fa4b238-803e-4bda-97ad-4c9c6f5e7eed"), new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2"), new Guid("0f951084-f7a7-46c9-9ef5-026555729cff") },
                    { new Guid("c276e765-0933-45b2-95b6-3c268670c0b4"), new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e"), new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b") },
                    { new Guid("fbe62561-f571-4340-ac8c-d77a895d6fdd"), new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2"), new Guid("8f315aa2-c1a8-48ad-a9b4-0220e1672aba") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("d01d0a4e-e5ec-4b48-acf4-212369497180"), new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83"), new Guid("3f5e3434-9098-49ec-8316-84ec6a143262") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b098240f-15d7-4870-a888-b77a357760bb", "42c2eece-7aae-42af-b8d4-a06a06c641ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "049e7085-70a9-43cb-8321-f89b1e892990", "56526b9d-8b8a-467f-ae44-2fc156eb713b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b098240f-15d7-4870-a888-b77a357760bb", "8c64655b-6d09-42bb-978a-c57d81292c6f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5122c945-fdf0-4b1c-852c-e4d2749b0206", "92e4891d-6021-4173-b406-1e6ea77652d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5122c945-fdf0-4b1c-852c-e4d2749b0206", "bdc70856-bdf4-4f1a-bba0-80cb79f88652" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("20d142b1-9d16-499a-8050-00b3d8560b7e"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("2c88d1af-50ac-4c04-b576-40839f8b9fc0"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("5561dae4-ee6c-4427-bcaa-84e821e8984d"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("6fb2b475-aa10-46c9-a1d0-c612195166f4"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("90bd34f8-1529-4768-bfa4-3734b97c8e3d"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("c17c1165-9105-4028-81f9-6aadf873d3ae"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("da617c51-f889-4d47-8157-3ac26b77bd8c"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("0dc79e73-2967-4b69-9c86-f1e14dd7a4b8"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("3dd91c48-4719-448b-ab73-1fa1af51294b"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("55722b2e-2bf3-456b-ae9f-29b394a8c90a"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("c22f6237-9bfb-4bc0-8cb4-b64b03f3ca30"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("cc5587ee-dd80-46c4-b99c-1b7c352c5a7a"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("0d3c22b8-a65c-42b0-be91-e381cd67208f"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("2839ef77-e63e-453c-b4a7-990d545bd8c0"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("4cdf22ae-dd89-4dd4-9d08-cc62e21c0253"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("6385beeb-6de1-4248-a0dc-c98498f9d241"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("7e5fd461-cbb2-4cd6-b3cb-da6d4979c533"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("99a1904f-d998-4afc-a141-d1b5f44c318c"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("e05bd7ad-8ab6-4fd3-a7b0-e152a78ee3f1"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("e2677d38-9806-4eb4-ba3a-7fd56ede4bd1"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("8fa4b238-803e-4bda-97ad-4c9c6f5e7eed"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("c276e765-0933-45b2-95b6-3c268670c0b4"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("fbe62561-f571-4340-ac8c-d77a895d6fdd"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("d01d0a4e-e5ec-4b48-acf4-212369497180"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "049e7085-70a9-43cb-8321-f89b1e892990");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5122c945-fdf0-4b1c-852c-e4d2749b0206");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b098240f-15d7-4870-a888-b77a357760bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56526b9d-8b8a-467f-ae44-2fc156eb713b");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("0c6e718b-76de-4f7f-8996-700f0fb524be"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("1a03ebd0-7952-406d-aa45-c1c56a2385e7"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("38505bf9-66f2-4dfb-9c27-ccfee2c22648"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("41f27d0b-7ee6-46ed-be95-9a3af04660cb"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("429e42d7-e8ce-4aff-a270-f73185aa02d6"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("9a3561f8-34b2-4174-9e85-c21cbefc4454"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("f1156230-f5f0-447b-aa5d-c613d0eefa74"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("faa3ca9f-28a6-4bb1-88ee-eaad290679b8"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("1b72531d-9656-4eaf-a0d6-bb06818cc3c2"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("4abeab86-9283-47ac-b05b-f8a377eada6e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("948ddd8c-709f-4800-8f6d-92fcc67d9d83"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("e0d50607-63e2-4c7a-8821-6a8c071f229e"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("0f951084-f7a7-46c9-9ef5-026555729cff"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("3f5e3434-9098-49ec-8316-84ec6a143262"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("7f6247dc-c197-40b1-8061-8e31c200ae8b"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("8f315aa2-c1a8-48ad-a9b4-0220e1672aba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42c2eece-7aae-42af-b8d4-a06a06c641ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c64655b-6d09-42bb-978a-c57d81292c6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92e4891d-6021-4173-b406-1e6ea77652d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdc70856-bdf4-4f1a-bba0-80cb79f88652");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApplicationUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71d3eda2-0069-41cc-9e76-09117bb977cd", null, "71d3eda2-0069-41cc-9e76-09117bb977cd", "Publisher", "PUBLISHER" },
                    { "99dd34ef-a62a-447b-9583-1e1ce6bf7723", null, "99dd34ef-a62a-447b-9583-1e1ce6bf7723", "Admin", "ADMIN" },
                    { "e566e2ec-825a-460b-9753-0d4525021d3a", null, "e566e2ec-825a-460b-9753-0d4525021d3a", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ea46bde-c4e1-4461-9abd-d1e213364d3f", 0, true, "dbd7ee92-2dd8-4a96-a818-5703da528c8a", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC03VHK6A1NtEMAQ6QL+bohjRzm5uDkmU+lVP79Wrm6vjLpQrVSiDw09lKUJ/WaP0A==", null, false, "733572b8-6326-4ae0-84c2-7c2b1618b4d8", false, "Nordic@hotmail.com" },
                    { "1fe12077-ee83-4362-86e4-136d8368b6a3", 0, true, "ee7d0cda-8322-4ef4-8b97-ed0ba753d825", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("aba8c345-3d08-4d90-b64b-fe34d65b9776"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAECLK5z7dBmyTmq4aP3+9dxAZpU9stSgAv8UUnQi4U5h3EC4Rpl3MZwPUE6JnKc3n4w==", null, false, "20b8b6b2-5690-442a-9f1e-80f3801b7d55", false, "lukas3302@hotmail.com" },
                    { "98988cb5-3ede-4f5a-95ab-34569e24290c", 0, true, "afc9708f-9d69-4980-8b21-906cf1a238ae", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFCqc3UUv17n7nBkGVyngPfWnKaieHGQKiwh9eguL4xvZCY13Cd35xIWTTihCm5ckA==", null, false, "7d2c2a45-fafc-402d-8d86-f5397ec1d237", false, "Admin@hotmail.com" },
                    { "b4665254-1122-480e-9473-7a945a0c753e", 0, true, "0c400bbe-b021-4aeb-847b-4b7d4ce75670", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK9f2/r5mppj71oIdnTmhl3Q2uZH6xsnNBP4hi5XqYdMRLah/wmwuduI3bljOvCBDg==", null, false, "0db19f29-48dd-45a7-b042-06538432fe1e", false, "Mellemgaard@hotmail.com" },
                    { "b7e58ae5-8976-401d-8e09-919e59f2266b", 0, true, "76a85aa0-67fa-457b-bcae-7f9b5744fe30", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFrQFmrsx5BNODONICue+VlQCa1Pn6D2QElzCnGTeC6fG+z0Jkk5onyysaZdVXz3ow==", null, false, "371fcebe-3aef-4c68-baf6-3d6ba68866a0", false, "jens2837@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "Available", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("4014ab42-199c-4dc2-ae1e-cfb51bf67b65"), "Gustave Aimard", true, 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("42973c3a-ea90-4411-bb22-f1ac78dece6a"), "Gustave Aimard", true, 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("49bf65b3-8cdc-4688-b955-7035d1e516b0"), "Gustave Aimard", true, 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("7fdcff5d-eea6-4f3d-b79c-60b929b4bf38"), "Charlotte M. Yonge", true, 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" },
                    { new Guid("802c8048-63d7-4f2a-8f19-dbfd8207c623"), "Gustave Aimard", true, 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 240, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("88e2d267-89b3-4289-afe3-13cde4b5ee37"), "Gustave Aimard", true, 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"), "Gustave Aimard", true, 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("cfefa5e0-0be9-4a62-b27c-f2058220ba9c"), "Gustave Aimard", true, 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 574, 19.949999999999999, "The Heir of Redclyffe" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("11fea985-f34a-4167-beed-505643d9d27f"), true, new DateTime(2024, 5, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7067), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7062), "Fantasy Hype" },
                    { new Guid("26c93320-1dc4-4571-bc12-d5f086a7e4dc"), true, new DateTime(2024, 6, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7110), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7105), "School books" },
                    { new Guid("83eaede9-0bcb-4e65-b69c-3a87e208d295"), true, new DateTime(2024, 5, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7090), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7074), "Book worm" },
                    { new Guid("a9a119ff-82ed-4acf-99be-3afe3519e66d"), true, new DateTime(2024, 5, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(7033), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 13, 10, 11, 16, 299, DateTimeKind.Local).AddTicks(6909), "Romance Mounth" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "71d3eda2-0069-41cc-9e76-09117bb977cd", "1ea46bde-c4e1-4461-9abd-d1e213364d3f" },
                    { "e566e2ec-825a-460b-9753-0d4525021d3a", "1fe12077-ee83-4362-86e4-136d8368b6a3" },
                    { "99dd34ef-a62a-447b-9583-1e1ce6bf7723", "98988cb5-3ede-4f5a-95ab-34569e24290c" },
                    { "71d3eda2-0069-41cc-9e76-09117bb977cd", "b4665254-1122-480e-9473-7a945a0c753e" },
                    { "e566e2ec-825a-460b-9753-0d4525021d3a", "b7e58ae5-8976-401d-8e09-919e59f2266b" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("54390f5b-3f3d-4d33-882b-759ef95fe3b3"), new Guid("cfefa5e0-0be9-4a62-b27c-f2058220ba9c"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("7d89a8be-6110-4b7a-bf59-b8d9f46d7d35"), new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("9cefc482-5442-49ef-804e-83929901c6a1"), new Guid("7fdcff5d-eea6-4f3d-b79c-60b929b4bf38"), new Guid("83eaede9-0bcb-4e65-b69c-3a87e208d295") },
                    { new Guid("ac9b8d11-d901-4684-98e3-9abbb45b7f28"), new Guid("802c8048-63d7-4f2a-8f19-dbfd8207c623"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("cd8c36b1-d8a1-4fb8-84bb-62572d38dc7c"), new Guid("88e2d267-89b3-4289-afe3-13cde4b5ee37"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("daf5ffe9-9393-4faa-9767-7f274d925bbd"), new Guid("49bf65b3-8cdc-4688-b955-7035d1e516b0"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("e02162c6-be18-4a3f-835e-08333c51d34a"), new Guid("42973c3a-ea90-4411-bb22-f1ac78dece6a"), new Guid("83eaede9-0bcb-4e65-b69c-3a87e208d295") },
                    { new Guid("f1e5f3cc-355e-4f9f-9973-ca3f380eed3a"), new Guid("4014ab42-199c-4dc2-ae1e-cfb51bf67b65"), new Guid("a9a119ff-82ed-4acf-99be-3afe3519e66d") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9"), "1ea46bde-c4e1-4461-9abd-d1e213364d3f", "Buster Nordic" },
                    { new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c"), "b4665254-1122-480e-9473-7a945a0c753e", "Forlaget Mellemgaard" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("aba8c345-3d08-4d90-b64b-fe34d65b9776"), "1fe12077-ee83-4362-86e4-136d8368b6a3" },
                    { new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c"), "b7e58ae5-8976-401d-8e09-919e59f2266b" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("33a56c83-6f6b-4f44-ad46-9133e89c0ec0"), new Guid("802c8048-63d7-4f2a-8f19-dbfd8207c623"), new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9") },
                    { new Guid("3cb443b2-0dc6-4848-b5f0-419e875b2e9d"), new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"), new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9") },
                    { new Guid("584cd805-6e80-4912-a729-f04c3b7843fd"), new Guid("cfefa5e0-0be9-4a62-b27c-f2058220ba9c"), new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9") },
                    { new Guid("7fa90e95-93f5-4f6f-b20e-dabe8bd7748a"), new Guid("7fdcff5d-eea6-4f3d-b79c-60b929b4bf38"), new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c") },
                    { new Guid("8d030ebd-c5c2-41f0-ab3f-39e424217ab1"), new Guid("4014ab42-199c-4dc2-ae1e-cfb51bf67b65"), new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c") },
                    { new Guid("9f2c3c3a-c5b7-4c8a-aefa-1782eac03637"), new Guid("88e2d267-89b3-4289-afe3-13cde4b5ee37"), new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9") },
                    { new Guid("b55f6abc-457b-40a0-aae6-ab35bb37dcc8"), new Guid("49bf65b3-8cdc-4688-b955-7035d1e516b0"), new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("1114142e-8763-4e68-89cf-ab0a9349c123"), new Guid("42973c3a-ea90-4411-bb22-f1ac78dece6a"), new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c") },
                    { new Guid("4250dc9b-8908-4044-8011-80444f5e9f36"), new Guid("88e2d267-89b3-4289-afe3-13cde4b5ee37"), new Guid("aba8c345-3d08-4d90-b64b-fe34d65b9776") },
                    { new Guid("708ae1cd-b7ec-4a30-a120-ad7867e316bd"), new Guid("cfefa5e0-0be9-4a62-b27c-f2058220ba9c"), new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c") },
                    { new Guid("b56ad657-c56b-4b09-af7c-066cb2b9dc91"), new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"), new Guid("aba8c345-3d08-4d90-b64b-fe34d65b9776") },
                    { new Guid("f1aa22be-b260-4b1c-8517-9d587d42f98c"), new Guid("c8267340-f844-4c33-a19c-61c7fd2c3f65"), new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("609a7401-d2f4-4ec4-b020-24f34611853f"), new Guid("400546fd-a965-413c-8f09-b0bf04c5acc9"), new Guid("11fea985-f34a-4167-beed-505643d9d27f") },
                    { new Guid("90d11d08-e86d-4e9c-b7b7-eb0e07463e47"), new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c"), new Guid("83eaede9-0bcb-4e65-b69c-3a87e208d295") },
                    { new Guid("d6bd33c2-5d93-4f65-8b59-43231af06c6a"), new Guid("b828c87a-9eb6-45be-bcf8-bbaa1925971c"), new Guid("a9a119ff-82ed-4acf-99be-3afe3519e66d") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("d2aa90c7-f798-49e5-8c26-a19bd6b22c8b"), new Guid("c388c882-ff34-4dfc-80ae-86dc2682d16c"), new Guid("26c93320-1dc4-4571-bc12-d5f086a7e4dc") });
        }
    }
}
