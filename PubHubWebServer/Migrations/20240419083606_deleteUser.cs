using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class deleteUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "592d7a1f-f50b-4a53-b37f-949f71403e90", null, "592d7a1f-f50b-4a53-b37f-949f71403e90", "Admin", "ADMIN" },
                    { "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", null, "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", "Reader", "READER" },
                    { "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", null, "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", "Publisher", "PUBLISHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a2c267b-e797-4d76-943b-4978910d712b", 0, true, "b9fbec78-9f11-4124-9792-75b04640e49b", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAELv5lHIp7hQUAkqT0Z6WnAEflFjkeYZwLBiX2xyHLRg/efYhQIsTxMQjk9RP6g1F4w==", null, false, "729bc364-fe0d-4b48-afd0-070be02d24b7", false, "jens2837@hotmail.com" },
                    { "4a96240e-75b4-430a-b573-196800bed474", 0, true, "30f78569-fddd-4142-8297-44b04f0d3c30", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ2a32nhZG/+uy6qxPXbJXCZeT+3HMN+GwvU/Dc9pLwUlmzzfb7pJ+zcPTAYPHTn+w==", null, false, "4932d415-797b-451c-a6cf-7623ef0e4641", false, "Mellemgaard@hotmail.com" },
                    { "5d0845d2-7a1b-4f84-abed-d754594c6090", 0, true, "8ab705a8-88a9-46d9-996e-821867156e57", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("3a2e81ed-91b5-43a2-8fa9-27d197fda520"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIRlcvJt+zq0AW1CAQatDp8s48Q4KZYOljdTlwGr4E+abUjkoWWqewVrjvBNtttgbQ==", null, false, "1811388c-8282-44cd-9d0f-aa15b41fe1dd", false, "lukas3302@hotmail.com" },
                    { "b87ad334-a40e-4036-917c-a9daa4f65f2b", 0, true, "45d41794-3bfc-4fb8-9a85-e1f9d2bfee0d", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOTitqenAabo0bT2BuMjD25Q9aIhPfXQTME0JBqFrcRZa3qt3xHDTUhyRtsV8D/E7g==", null, false, "e2784f36-624c-4991-b8ef-3804df686f61", false, "Admin@hotmail.com" },
                    { "ce8f69c3-e477-4bdd-a68a-1f446a1c74bd", 0, true, "5785e6d4-64f1-450b-ab97-8e77b0db7202", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBBQMEa033lg8u2rdo1pdYi+of70w/DrxNkxsELWpks12wSazc/TnceJIqhSmZhuVg==", null, false, "30aeedaa-b192-4007-afd3-0e49524b79a0", false, "Nordic@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "Available", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("062bf5ed-0c4d-4e88-a4e1-455fa9a6b280"), "Gustave Aimard", true, 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 428L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 275, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("340a4b77-9aca-4d31-8722-d3eaa34f2c8e"), "Gustave Aimard", true, 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 236, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("460e7255-2bcd-46ac-adb5-6170d4e192d3"), "Gustave Aimard", true, 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 637, 19.949999999999999, "The Heir of Redclyffe" },
                    { new Guid("579c6e40-058d-4e8c-b1e3-223ed84f779e"), "Charlotte M. Yonge", true, 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 50L, "History-of-France", "History", 112, 89.0, "History of France" },
                    { new Guid("6088009e-b3ea-47c1-981d-a170b68d29fa"), "Gustave Aimard", true, 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 127L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 275, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("baecd670-ed42-4c34-a0cb-3540970c5a28"), "Gustave Aimard", true, 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 23L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 303.0, "The Smuggler Chief" },
                    { new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"), "Gustave Aimard", true, 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 6487L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 381, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("f72bc9e2-7515-40fa-a202-a057922a5238"), "Gustave Aimard", true, 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 9846L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("53e3c551-63d4-4c1e-90d6-941952822a1e"), true, new DateTime(2024, 5, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9582), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9517), "Romance Mounth" },
                    { new Guid("636a2e61-b534-4391-9d42-01153216fa5e"), true, new DateTime(2024, 5, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9594), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9592), "Fantasy Hype" },
                    { new Guid("6cdf21c7-b467-484a-842c-f6b33d0f9091"), true, new DateTime(2024, 5, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9605), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9597), "Book worm" },
                    { new Guid("bbd7e3e2-c03a-40f6-91a6-a448bdb909c7"), true, new DateTime(2024, 6, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9619), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 19, 10, 36, 5, 454, DateTimeKind.Local).AddTicks(9617), "School books" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", "0a2c267b-e797-4d76-943b-4978910d712b" },
                    { "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", "4a96240e-75b4-430a-b573-196800bed474" },
                    { "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", "5d0845d2-7a1b-4f84-abed-d754594c6090" },
                    { "592d7a1f-f50b-4a53-b37f-949f71403e90", "b87ad334-a40e-4036-917c-a9daa4f65f2b" },
                    { "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", "ce8f69c3-e477-4bdd-a68a-1f446a1c74bd" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("0a5e2de5-add0-4cc4-8a39-495936701ca2"), new Guid("340a4b77-9aca-4d31-8722-d3eaa34f2c8e"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") },
                    { new Guid("2cc9c998-c96d-4946-abdf-815ae12559c0"), new Guid("579c6e40-058d-4e8c-b1e3-223ed84f779e"), new Guid("6cdf21c7-b467-484a-842c-f6b33d0f9091") },
                    { new Guid("359fec4b-ce3b-4bde-868e-add40ed3df12"), new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") },
                    { new Guid("371651ec-357a-4479-9ee2-313805c30fea"), new Guid("460e7255-2bcd-46ac-adb5-6170d4e192d3"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") },
                    { new Guid("490b5ead-ae32-4a58-a208-c70766d54cb8"), new Guid("6088009e-b3ea-47c1-981d-a170b68d29fa"), new Guid("53e3c551-63d4-4c1e-90d6-941952822a1e") },
                    { new Guid("78110b39-4774-4e48-9750-1242d3468ae0"), new Guid("062bf5ed-0c4d-4e88-a4e1-455fa9a6b280"), new Guid("6cdf21c7-b467-484a-842c-f6b33d0f9091") },
                    { new Guid("8ecac4f2-308f-4294-8b4e-101b252f56ad"), new Guid("f72bc9e2-7515-40fa-a202-a057922a5238"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") },
                    { new Guid("a66f9f7d-6bb6-4c55-912e-b118f6ba5b01"), new Guid("baecd670-ed42-4c34-a0cb-3540970c5a28"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e"), "4a96240e-75b4-430a-b573-196800bed474", "Forlaget Mellemgaard" },
                    { new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1"), "ce8f69c3-e477-4bdd-a68a-1f446a1c74bd", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd"), "0a2c267b-e797-4d76-943b-4978910d712b" },
                    { new Guid("3a2e81ed-91b5-43a2-8fa9-27d197fda520"), "5d0845d2-7a1b-4f84-abed-d754594c6090" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("06a10d6d-da61-4df2-a1b1-cbbd5f035d80"), new Guid("f72bc9e2-7515-40fa-a202-a057922a5238"), new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e") },
                    { new Guid("0c84fc18-8970-4f36-839d-82d0a538681e"), new Guid("340a4b77-9aca-4d31-8722-d3eaa34f2c8e"), new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1") },
                    { new Guid("1f404a79-e98c-4bd4-b925-82b5e7927224"), new Guid("460e7255-2bcd-46ac-adb5-6170d4e192d3"), new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1") },
                    { new Guid("3e16700b-e1ad-406e-b092-ecff1278ed24"), new Guid("579c6e40-058d-4e8c-b1e3-223ed84f779e"), new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e") },
                    { new Guid("69bc649f-adae-4ed2-a553-8189b91644d9"), new Guid("6088009e-b3ea-47c1-981d-a170b68d29fa"), new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e") },
                    { new Guid("7de83de3-eaef-4aac-afa2-a3dc1b2c08fb"), new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"), new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1") },
                    { new Guid("b526f256-c7e0-4df0-ae1c-d42f52fecc56"), new Guid("baecd670-ed42-4c34-a0cb-3540970c5a28"), new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("22cb95d5-61bb-44c9-b8ad-a9c098d684ca"), new Guid("baecd670-ed42-4c34-a0cb-3540970c5a28"), new Guid("3a2e81ed-91b5-43a2-8fa9-27d197fda520") },
                    { new Guid("22e700f1-355c-4944-8e8f-67dc6b35b52a"), new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"), new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd") },
                    { new Guid("cf57b0c0-281c-4316-8501-1c73f8578179"), new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"), new Guid("3a2e81ed-91b5-43a2-8fa9-27d197fda520") },
                    { new Guid("d5f783de-e8a2-41b6-8a58-339e921f331d"), new Guid("460e7255-2bcd-46ac-adb5-6170d4e192d3"), new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd") },
                    { new Guid("db17068f-432e-41b3-a46f-a3b593297b44"), new Guid("062bf5ed-0c4d-4e88-a4e1-455fa9a6b280"), new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("8e2d9f4d-a7b2-4393-8088-38590dac10a4"), new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1"), new Guid("636a2e61-b534-4391-9d42-01153216fa5e") },
                    { new Guid("97ea9ddb-73a2-4859-acc5-966ea212fb44"), new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e"), new Guid("53e3c551-63d4-4c1e-90d6-941952822a1e") },
                    { new Guid("fe0891c0-dc92-4ea4-b413-304df89350a2"), new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e"), new Guid("6cdf21c7-b467-484a-842c-f6b33d0f9091") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("eebad081-c37f-456e-869f-3f90f5daf6b3"), new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd"), new Guid("bbd7e3e2-c03a-40f6-91a6-a448bdb909c7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", "0a2c267b-e797-4d76-943b-4978910d712b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", "4a96240e-75b4-430a-b573-196800bed474" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6326c43d-2edc-40d7-b7e4-3168ab7f7e86", "5d0845d2-7a1b-4f84-abed-d754594c6090" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "592d7a1f-f50b-4a53-b37f-949f71403e90", "b87ad334-a40e-4036-917c-a9daa4f65f2b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be", "ce8f69c3-e477-4bdd-a68a-1f446a1c74bd" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("06a10d6d-da61-4df2-a1b1-cbbd5f035d80"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("0c84fc18-8970-4f36-839d-82d0a538681e"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("1f404a79-e98c-4bd4-b925-82b5e7927224"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("3e16700b-e1ad-406e-b092-ecff1278ed24"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("69bc649f-adae-4ed2-a553-8189b91644d9"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("7de83de3-eaef-4aac-afa2-a3dc1b2c08fb"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("b526f256-c7e0-4df0-ae1c-d42f52fecc56"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("22cb95d5-61bb-44c9-b8ad-a9c098d684ca"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("22e700f1-355c-4944-8e8f-67dc6b35b52a"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("cf57b0c0-281c-4316-8501-1c73f8578179"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("d5f783de-e8a2-41b6-8a58-339e921f331d"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("db17068f-432e-41b3-a46f-a3b593297b44"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("0a5e2de5-add0-4cc4-8a39-495936701ca2"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("2cc9c998-c96d-4946-abdf-815ae12559c0"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("359fec4b-ce3b-4bde-868e-add40ed3df12"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("371651ec-357a-4479-9ee2-313805c30fea"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("490b5ead-ae32-4a58-a208-c70766d54cb8"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("78110b39-4774-4e48-9750-1242d3468ae0"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("8ecac4f2-308f-4294-8b4e-101b252f56ad"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("a66f9f7d-6bb6-4c55-912e-b118f6ba5b01"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("8e2d9f4d-a7b2-4393-8088-38590dac10a4"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("97ea9ddb-73a2-4859-acc5-966ea212fb44"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("fe0891c0-dc92-4ea4-b413-304df89350a2"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("eebad081-c37f-456e-869f-3f90f5daf6b3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "592d7a1f-f50b-4a53-b37f-949f71403e90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6326c43d-2edc-40d7-b7e4-3168ab7f7e86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb26b9fa-e9d3-4cbe-a26b-3dbe4e05d9be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87ad334-a40e-4036-917c-a9daa4f65f2b");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("062bf5ed-0c4d-4e88-a4e1-455fa9a6b280"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("340a4b77-9aca-4d31-8722-d3eaa34f2c8e"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("460e7255-2bcd-46ac-adb5-6170d4e192d3"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("579c6e40-058d-4e8c-b1e3-223ed84f779e"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("6088009e-b3ea-47c1-981d-a170b68d29fa"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("baecd670-ed42-4c34-a0cb-3540970c5a28"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("e92ea432-917d-49e0-be8b-d1cd61ad8dac"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("f72bc9e2-7515-40fa-a202-a057922a5238"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("4bc8fa1f-1e83-4a64-92e1-9cd779df8c4e"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("866151ee-3fed-48cc-8c93-09a9c5f8a6a1"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("0393b824-830e-4fb1-845f-d1bba2fbcadd"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("3a2e81ed-91b5-43a2-8fa9-27d197fda520"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("53e3c551-63d4-4c1e-90d6-941952822a1e"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("636a2e61-b534-4391-9d42-01153216fa5e"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("6cdf21c7-b467-484a-842c-f6b33d0f9091"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("bbd7e3e2-c03a-40f6-91a6-a448bdb909c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a2c267b-e797-4d76-943b-4978910d712b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a96240e-75b4-430a-b573-196800bed474");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d0845d2-7a1b-4f84-abed-d754594c6090");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce8f69c3-e477-4bdd-a68a-1f446a1c74bd");

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
    }
}
