using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class AddedDownloadCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2f882fde-95fa-456f-ad07-55dde01d55ba", null, "2f882fde-95fa-456f-ad07-55dde01d55ba", "Admin", "ADMIN" },
                    { "5e2f79d3-341b-4e69-9487-f18273341921", null, "5e2f79d3-341b-4e69-9487-f18273341921", "Reader", "READER" },
                    { "f8121c02-2dab-40a2-88a3-e1e2615431b4", null, "f8121c02-2dab-40a2-88a3-e1e2615431b4", "Publisher", "PUBLISHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "031ca000-fdf8-4e1c-9d63-0d5aeec69dc3", 0, true, "5e4f9c0e-3b58-41a7-a1b1-bf3c50755f61", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("995444c1-32b1-4598-a4c7-4abfa2377846"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPJxSjdNqkXYV24mYXiPAHA6NIRJrFsTG9odli1PKeeG24JWerhmTRg8PFTSpzctjw==", null, false, "9bb8dd51-3864-4d01-bee1-79818809f4aa", false, "lukas3302@hotmail.com" },
                    { "17c02c68-c089-497b-8a13-99768b1e2b10", 0, true, "ef8384b0-8764-4cf5-9130-8a15f6425898", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF4guuja317Q8+0AsltI9lD0x1DIjpRT87BEBf+DWjx1hcxQSNikQc5+I3EgeL82kQ==", null, false, "e127f6f2-a4de-490e-bf8f-6d819f2fbac6", false, "Mellemgaard@hotmail.com" },
                    { "28c0a4a1-ebf8-40a1-8059-ef5e851813e4", 0, true, "640128d3-de64-47d7-bb5e-548839da6cbd", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("bdd722f1-5593-4bb4-97fb-50c306711048"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDsDzOtIVJILMJy244qm+LooUTfTr0v19OjAOxzIrDCI6D0dsSan3LX0GXI9ncohbA==", null, false, "8559b5a2-1c1e-430e-a0f8-88c7e48d0b49", false, "Nordic@hotmail.com" },
                    { "b39d151a-0a90-432f-a050-a14cd7603757", 0, true, "28c4c1ff-55dc-40bb-8332-f8f9cf85c2fc", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGObqy2tnmbOAn9wYs5WicrRGjHaxQAIDhoyfsV17CVt8U7DDS52U5ZB97FhTCqY6g==", null, false, "f4a65185-99a7-435d-9c3a-7a5db9beea7d", false, "Admin@hotmail.com" },
                    { "b51b4507-88b5-4239-a2f8-fc2398a5a502", 0, true, "039aa3a6-f63a-4944-b1b7-330ff1b9788b", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAEECWkMFMEwc60EqK/qHhSs6J0sGXdNjHzrckRvMfp0Af0LqI1bvw1TDpL96tcNF/TA==", null, false, "51768a64-4a2c-4814-89ca-66ad5bf076b0", false, "jens2837@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "Available", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("02edbeb5-bba3-4a4e-8ddc-d4ff7722ca52"), "Gustave Aimard", true, 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 23L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 303.0, "The Smuggler Chief" },
                    { new Guid("3294f8bc-df07-45ec-9769-34d8876892f2"), "Gustave Aimard", true, 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 127L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 275, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("33f08fba-e9dd-46e4-bda5-03b60afe7fdd"), "Charlotte M. Yonge", true, 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 50L, "History-of-France", "History", 112, 89.0, "History of France" },
                    { new Guid("380ffe03-36d7-437b-bbc2-c42728ef645f"), "Gustave Aimard", true, 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 428L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 275, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("5c905d02-bb7b-4974-8015-381646fcac28"), "Gustave Aimard", true, 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 9846L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("73384b0b-2d57-4f62-8344-18cd0cab8552"), "Gustave Aimard", true, 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 236, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("737daef9-005c-4056-ad8e-5a490e660303"), "Gustave Aimard", true, 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 6487L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 381, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("bc63047d-2784-49c1-8a0e-c6e7faa15111"), "Gustave Aimard", true, 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 637, 19.949999999999999, "The Heir of Redclyffe" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0c67f3b2-7027-43ed-8684-c268d7524912"), true, new DateTime(2024, 5, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6962), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6960), "Fantasy Hype" },
                    { new Guid("1ad7ad04-5cf0-4abb-81f2-acc9951ad890"), true, new DateTime(2024, 6, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6983), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6981), "School books" },
                    { new Guid("eb5ddfea-41a2-4e5d-8069-7fee29b40d8e"), true, new DateTime(2024, 5, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6973), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6965), "Book worm" },
                    { new Guid("f8e6933c-1755-41e2-a019-963fb20c22b4"), true, new DateTime(2024, 5, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6942), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 17, 9, 27, 23, 762, DateTimeKind.Local).AddTicks(6875), "Romance Mounth" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5e2f79d3-341b-4e69-9487-f18273341921", "031ca000-fdf8-4e1c-9d63-0d5aeec69dc3" },
                    { "f8121c02-2dab-40a2-88a3-e1e2615431b4", "17c02c68-c089-497b-8a13-99768b1e2b10" },
                    { "f8121c02-2dab-40a2-88a3-e1e2615431b4", "28c0a4a1-ebf8-40a1-8059-ef5e851813e4" },
                    { "2f882fde-95fa-456f-ad07-55dde01d55ba", "b39d151a-0a90-432f-a050-a14cd7603757" },
                    { "5e2f79d3-341b-4e69-9487-f18273341921", "b51b4507-88b5-4239-a2f8-fc2398a5a502" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("248f06ac-0682-42ce-9ec0-f79e2c96da46"), new Guid("33f08fba-e9dd-46e4-bda5-03b60afe7fdd"), new Guid("eb5ddfea-41a2-4e5d-8069-7fee29b40d8e") },
                    { new Guid("5198268a-558c-4bf5-af53-43e9a1984d18"), new Guid("73384b0b-2d57-4f62-8344-18cd0cab8552"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") },
                    { new Guid("558d0988-dbfe-47d5-9388-a358c9825ccf"), new Guid("737daef9-005c-4056-ad8e-5a490e660303"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") },
                    { new Guid("68284aff-74fc-4375-ac31-809f498ba3d5"), new Guid("5c905d02-bb7b-4974-8015-381646fcac28"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") },
                    { new Guid("855d277a-ed26-4d97-9ea3-778f0d8493ca"), new Guid("3294f8bc-df07-45ec-9769-34d8876892f2"), new Guid("f8e6933c-1755-41e2-a019-963fb20c22b4") },
                    { new Guid("b942975d-873a-4e8a-9937-69c4507ef19c"), new Guid("380ffe03-36d7-437b-bbc2-c42728ef645f"), new Guid("eb5ddfea-41a2-4e5d-8069-7fee29b40d8e") },
                    { new Guid("c9cc7c62-7a19-4ad3-926b-464d7465003f"), new Guid("bc63047d-2784-49c1-8a0e-c6e7faa15111"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") },
                    { new Guid("ca93ba47-e5bd-42de-8885-90f1be56db1e"), new Guid("02edbeb5-bba3-4a4e-8ddc-d4ff7722ca52"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f"), "17c02c68-c089-497b-8a13-99768b1e2b10", "Forlaget Mellemgaard" },
                    { new Guid("bdd722f1-5593-4bb4-97fb-50c306711048"), "28c0a4a1-ebf8-40a1-8059-ef5e851813e4", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("995444c1-32b1-4598-a4c7-4abfa2377846"), "031ca000-fdf8-4e1c-9d63-0d5aeec69dc3" },
                    { new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d"), "b51b4507-88b5-4239-a2f8-fc2398a5a502" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("283bb124-bff9-4944-a3b0-7b53b00137af"), new Guid("73384b0b-2d57-4f62-8344-18cd0cab8552"), new Guid("bdd722f1-5593-4bb4-97fb-50c306711048") },
                    { new Guid("6548b014-daf1-40df-82ce-b0af9b01f86c"), new Guid("bc63047d-2784-49c1-8a0e-c6e7faa15111"), new Guid("bdd722f1-5593-4bb4-97fb-50c306711048") },
                    { new Guid("7addf79f-138f-40db-91ff-0e2e1787428e"), new Guid("737daef9-005c-4056-ad8e-5a490e660303"), new Guid("bdd722f1-5593-4bb4-97fb-50c306711048") },
                    { new Guid("ab205c8c-8d4e-4381-850b-6b562c3a549d"), new Guid("5c905d02-bb7b-4974-8015-381646fcac28"), new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f") },
                    { new Guid("bfb99713-e016-4787-8c02-9421cc9bbb31"), new Guid("3294f8bc-df07-45ec-9769-34d8876892f2"), new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f") },
                    { new Guid("e6268096-5861-4db2-a858-911f61b1a153"), new Guid("02edbeb5-bba3-4a4e-8ddc-d4ff7722ca52"), new Guid("bdd722f1-5593-4bb4-97fb-50c306711048") },
                    { new Guid("f2801096-dbcf-43e2-80c0-38e28d4d6798"), new Guid("33f08fba-e9dd-46e4-bda5-03b60afe7fdd"), new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("23e8cd81-9d22-410a-b9cf-95b9bd47c338"), new Guid("02edbeb5-bba3-4a4e-8ddc-d4ff7722ca52"), new Guid("995444c1-32b1-4598-a4c7-4abfa2377846") },
                    { new Guid("8bc5b866-5526-4f35-b7a9-c79d658bda4f"), new Guid("737daef9-005c-4056-ad8e-5a490e660303"), new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d") },
                    { new Guid("909f06aa-659b-4f26-9fd2-5e7fe8558a92"), new Guid("737daef9-005c-4056-ad8e-5a490e660303"), new Guid("995444c1-32b1-4598-a4c7-4abfa2377846") },
                    { new Guid("abf8fea4-a497-4bd3-978d-ba10cd8f3b81"), new Guid("380ffe03-36d7-437b-bbc2-c42728ef645f"), new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d") },
                    { new Guid("aee75b71-a280-4222-a79b-29a7e908c8c6"), new Guid("bc63047d-2784-49c1-8a0e-c6e7faa15111"), new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("0eaeacfc-d77d-4d67-8afb-f16c0080491f"), new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f"), new Guid("eb5ddfea-41a2-4e5d-8069-7fee29b40d8e") },
                    { new Guid("7e170215-09ef-4873-8525-5a3599de6d62"), new Guid("bdd722f1-5593-4bb4-97fb-50c306711048"), new Guid("0c67f3b2-7027-43ed-8684-c268d7524912") },
                    { new Guid("9ff54dcb-62b1-4fcd-a646-1bce92b10db5"), new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f"), new Guid("f8e6933c-1755-41e2-a019-963fb20c22b4") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("9d7a6278-8069-415c-8c24-99640df1b11a"), new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d"), new Guid("1ad7ad04-5cf0-4abb-81f2-acc9951ad890") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e2f79d3-341b-4e69-9487-f18273341921", "031ca000-fdf8-4e1c-9d63-0d5aeec69dc3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8121c02-2dab-40a2-88a3-e1e2615431b4", "17c02c68-c089-497b-8a13-99768b1e2b10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8121c02-2dab-40a2-88a3-e1e2615431b4", "28c0a4a1-ebf8-40a1-8059-ef5e851813e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f882fde-95fa-456f-ad07-55dde01d55ba", "b39d151a-0a90-432f-a050-a14cd7603757" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e2f79d3-341b-4e69-9487-f18273341921", "b51b4507-88b5-4239-a2f8-fc2398a5a502" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("283bb124-bff9-4944-a3b0-7b53b00137af"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("6548b014-daf1-40df-82ce-b0af9b01f86c"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("7addf79f-138f-40db-91ff-0e2e1787428e"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("ab205c8c-8d4e-4381-850b-6b562c3a549d"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("bfb99713-e016-4787-8c02-9421cc9bbb31"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("e6268096-5861-4db2-a858-911f61b1a153"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("f2801096-dbcf-43e2-80c0-38e28d4d6798"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("23e8cd81-9d22-410a-b9cf-95b9bd47c338"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("8bc5b866-5526-4f35-b7a9-c79d658bda4f"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("909f06aa-659b-4f26-9fd2-5e7fe8558a92"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("abf8fea4-a497-4bd3-978d-ba10cd8f3b81"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("aee75b71-a280-4222-a79b-29a7e908c8c6"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("248f06ac-0682-42ce-9ec0-f79e2c96da46"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("5198268a-558c-4bf5-af53-43e9a1984d18"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("558d0988-dbfe-47d5-9388-a358c9825ccf"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("68284aff-74fc-4375-ac31-809f498ba3d5"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("855d277a-ed26-4d97-9ea3-778f0d8493ca"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("b942975d-873a-4e8a-9937-69c4507ef19c"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("c9cc7c62-7a19-4ad3-926b-464d7465003f"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("ca93ba47-e5bd-42de-8885-90f1be56db1e"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("0eaeacfc-d77d-4d67-8afb-f16c0080491f"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("7e170215-09ef-4873-8525-5a3599de6d62"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("9ff54dcb-62b1-4fcd-a646-1bce92b10db5"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("9d7a6278-8069-415c-8c24-99640df1b11a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f882fde-95fa-456f-ad07-55dde01d55ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e2f79d3-341b-4e69-9487-f18273341921");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8121c02-2dab-40a2-88a3-e1e2615431b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b39d151a-0a90-432f-a050-a14cd7603757");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("02edbeb5-bba3-4a4e-8ddc-d4ff7722ca52"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("3294f8bc-df07-45ec-9769-34d8876892f2"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("33f08fba-e9dd-46e4-bda5-03b60afe7fdd"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("380ffe03-36d7-437b-bbc2-c42728ef645f"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("5c905d02-bb7b-4974-8015-381646fcac28"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("73384b0b-2d57-4f62-8344-18cd0cab8552"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("737daef9-005c-4056-ad8e-5a490e660303"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("bc63047d-2784-49c1-8a0e-c6e7faa15111"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("0561bbeb-d706-4836-a4f5-86e595e7cc6f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("bdd722f1-5593-4bb4-97fb-50c306711048"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("995444c1-32b1-4598-a4c7-4abfa2377846"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("c90449e5-a5be-4fd2-9fcd-9397072aaf0d"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("0c67f3b2-7027-43ed-8684-c268d7524912"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("1ad7ad04-5cf0-4abb-81f2-acc9951ad890"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("eb5ddfea-41a2-4e5d-8069-7fee29b40d8e"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("f8e6933c-1755-41e2-a019-963fb20c22b4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031ca000-fdf8-4e1c-9d63-0d5aeec69dc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17c02c68-c089-497b-8a13-99768b1e2b10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28c0a4a1-ebf8-40a1-8059-ef5e851813e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b51b4507-88b5-4239-a2f8-fc2398a5a502");

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
    }
}
