using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class FixedSpellingMistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed24e676-706b-4900-aca3-64447375bc0f", "90c6b1e4-4c51-42a1-8a87-74c1d0de041f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "380030f1-cc81-420d-af3d-6b057ce258a6", "a53c8fb9-e56c-4cd3-9aa7-23ba6cf5c59f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9b035ccf-ffd1-438a-be8f-83bacfe4bace", "b9eae165-e18c-48a9-832f-f8e48a448beb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9b035ccf-ffd1-438a-be8f-83bacfe4bace", "c14a84f5-ee67-4c8b-a633-5b2c041a5f5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed24e676-706b-4900-aca3-64447375bc0f", "c1672b48-42c0-4439-8038-eb275ef7863f" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("2ab15c60-5c39-4c9d-8844-1f61e8e1d5c4"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("51a021e8-5023-4aeb-a083-29e31ba7aaee"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("698e0807-ffc0-42de-880f-989a4d29b854"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("78d5b52a-ff81-4c6c-b596-e85b5c810fb1"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("8e61b2e7-3301-42e1-a993-4166ac0f8dab"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("ae91fdfb-e35f-4713-9695-75bc94a298e0"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("fb90970e-a3bf-45e0-88d8-8671fe6ad762"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("536f5175-69cf-47dd-bc73-e4319083673a"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("76338351-e6b0-441d-8aee-cf248b24c2b9"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("7b328cc8-1136-4757-834e-d5af639e1122"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("b153534b-b9c2-4e29-8809-5a4bffd453a7"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("b286b342-bd31-4765-8fe7-50e585956036"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("0cb91807-7ca5-433d-b843-a1b5fdd12cf6"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("207a4aab-ffd0-4fa3-a17f-ac65a5199b99"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("5f970849-652e-439f-88b9-bc6952affa89"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("603dcdf6-9679-4a83-aa32-c4571be457b3"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("75f342fb-13cf-46ac-aa97-ef93afa867b8"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("8ad2f863-1b48-4b39-ab85-1e6d2e2f85f6"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("bed8f677-0372-4784-b577-52ffda38e0cf"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("f4ad3e10-8ce5-452e-9533-0781cc5a2091"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("4c0a86b0-6146-45da-bb3d-3468597b56d0"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("8b59f7b1-cb20-4f8e-aa58-f959549d3273"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("b5ea3011-03fd-4738-9ffa-cb03cd7b8e54"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("d118b27e-0196-4f1b-9b2d-bfaec34c66a2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "380030f1-cc81-420d-af3d-6b057ce258a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b035ccf-ffd1-438a-be8f-83bacfe4bace");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed24e676-706b-4900-aca3-64447375bc0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a53c8fb9-e56c-4cd3-9aa7-23ba6cf5c59f");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("0fbc59e2-5f35-4da2-be03-84da515f2cab"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("42fb8e87-42b8-4b37-a8f8-302c0dcbbdf1"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("54f8d4fa-09e6-45f0-81e1-f98876852b76"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("8b8a39ec-006b-43c0-975f-b0c91e7ad5ce"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("a28d4719-c5c9-4240-a025-e350c9bd722a"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("ac71b766-9c44-423f-9c17-c1b81f0b7d73"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("bc5e4e13-ac1c-485c-8255-7619296e633f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("af4119b4-352f-4690-98ef-cf576b0400db"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("4256c227-591e-41af-b705-677b1502d37d"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("633a99f4-122f-43b6-a815-1793d3b1d1d8"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("ad62eb17-501c-431c-84fb-541a76d623c5"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90c6b1e4-4c51-42a1-8a87-74c1d0de041f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9eae165-e18c-48a9-832f-f8e48a448beb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c14a84f5-ee67-4c8b-a633-5b2c041a5f5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1672b48-42c0-4439-8038-eb275ef7863f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "380030f1-cc81-420d-af3d-6b057ce258a6", null, "380030f1-cc81-420d-af3d-6b057ce258a6", "Admin", "ADMIN" },
                    { "9b035ccf-ffd1-438a-be8f-83bacfe4bace", null, "9b035ccf-ffd1-438a-be8f-83bacfe4bace", "Publisher", "PUBLISHER" },
                    { "ed24e676-706b-4900-aca3-64447375bc0f", null, "ed24e676-706b-4900-aca3-64447375bc0f", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "90c6b1e4-4c51-42a1-8a87-74c1d0de041f", 0, true, "91d021dd-fa0f-40ff-a989-85ef8c6e6ae0", "ApplicationUser", "lukas3302@hotmail.com", true, true, null, new Guid("af4119b4-352f-4690-98ef-cf576b0400db"), "LUKAS3302@HOTMAIL.COM", "LUKAS3302@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIxd98oQ1RHQzNx88rKGJIy/+RF/lX4zXmSoDo7LC/I/dQ91NCrJvuTR4w9Gksq5cA==", null, false, "798b9032-92b4-4045-997c-108e155ea7e1", false, "lukas3302@hotmail.com" },
                    { "a53c8fb9-e56c-4cd3-9aa7-23ba6cf5c59f", 0, true, "82da0866-568f-4a44-802b-41bc6e4efe89", "ApplicationUser", "Admin@hotmail.com", true, true, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDFaM9Vp1+HTXKfazzcY0Wyq5pqs0psh8KDj397d101fYRae5aRokiZ8PWtCntoW7Q==", null, false, "9be4ba6e-13b1-4802-b355-66abc6e575ad", false, "Admin@hotmail.com" },
                    { "b9eae165-e18c-48a9-832f-f8e48a448beb", 0, true, "e0117b0c-f66a-436b-bca1-04d6b080302b", "ApplicationUser", "Nordic@hotmail.com", true, true, null, new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1"), "NORDIC@HOTMAIL.COM", "NORDIC@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHp5A9jKfP3+GMF/3UobE/lGKe4YUCrU9O2ySSSeysYpkANCzcXUB/RTMvO3U0lw6A==", null, false, "b8fb0cf1-499a-47e9-83cb-37a923b72647", false, "Nordic@hotmail.com" },
                    { "c14a84f5-ee67-4c8b-a633-5b2c041a5f5d", 0, true, "e8a55ce3-5615-4565-891d-e9b1d91af5e6", "ApplicationUser", "Mellemgaard@hotmail.com", true, true, null, new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147"), "MELLEMGAARD@HOTMAIL.COM", "MELLEMGAARD@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHRprFgCLFJGeBZTFkpDo5sEseUk8nIl/HsyNIG9L+jws8fpJ3M4b7hgJkMMK378EQ==", null, false, "7fd90c38-cc53-4e3e-acd5-6961b1cfbdd7", false, "Mellemgaard@hotmail.com" },
                    { "c1672b48-42c0-4439-8038-eb275ef7863f", 0, true, "2243f7ac-cd9c-4618-8861-a093a841d38a", "ApplicationUser", "Jens2837@hotmail.com", true, true, null, new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8"), "JENS2837@HOTMAIL.COM", "JENS2837@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKUeBZ8FHoJEsgIqXFGj6FR76wnufZgCZsHHdI9XNWfXYq6wzZKYwOyX7ltJKWvjWw==", null, false, "10099d98-7e26-43f4-951f-96331b879157", false, "ens2837@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "Available", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("0fbc59e2-5f35-4da2-be03-84da515f2cab"), "Gustave Aimard", true, 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("42fb8e87-42b8-4b37-a8f8-302c0dcbbdf1"), "Gustave Aimard", true, 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("54f8d4fa-09e6-45f0-81e1-f98876852b76"), "Gustave Aimard", true, 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("8b8a39ec-006b-43c0-975f-b0c91e7ad5ce"), "Gustave Aimard", true, 9.0, "The Heir of Redclyffe tells the story of Guy Morville, heir to the Redclyffe estate and baronetcy, and his cousin Philip Morville, a conceited hypocrite who enjoys an unwarrantedly high reputation, and of the two sisters whom they love, Amabel and Laura. When Guy raises money to secretly pay off the debts of his blackguard uncle, Philip spreads the rumour that Guy is a reckless gambler. As a result Guy's proposed marriage to Amabel (Amy), who is his guardian's daughter, is called off and he is disowned by his guardian. Guy bears the situation with a new-found Christian fortitude until the uncle clears his character, enabling him to marry Amy after all. They honeymoon in Italy, finding Philip there suffering from a life-threatening fever. Guy nurses him back to health, but catches the fever himself and dies. Philip, transformed by contrition, inherits Redclyffe and marries Laura. Amy has a daughter after her husband's death and says she is happy in her Christian faith and with her daughter.", 0L, "The-Heir-of-Redclyffe", "Thriller French Adventure", 574, 19.949999999999999, "The Heir of Redclyffe" },
                    { new Guid("a28d4719-c5c9-4240-a025-e350c9bd722a"), "Gustave Aimard", true, 23.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Adventure", 240, 66.950000000000003, "The Bee Hunters: A Tale of Adventure" },
                    { new Guid("ac71b766-9c44-423f-9c17-c1b81f0b7d73"), "Gustave Aimard", true, 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"), "Gustave Aimard", true, 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("bc5e4e13-ac1c-485c-8255-7619296e633f"), "Charlotte M. Yonge", true, 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionID", "Active", "EndDate", "Message", "Price", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4256c227-591e-41af-b705-677b1502d37d"), true, new DateTime(2024, 6, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6544), "My colliction of books i need for school", 49.950000000000003, new DateTime(2024, 4, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6539), "School books" },
                    { new Guid("633a99f4-122f-43b6-a815-1793d3b1d1d8"), true, new DateTime(2024, 5, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6468), "This mounth we are running a campain to spread the love. so subscripe today to get all thoes juicy details", 119.95, new DateTime(2024, 4, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6387), "Romance Mounth" },
                    { new Guid("ad62eb17-501c-431c-84fb-541a76d623c5"), true, new DateTime(2024, 5, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6521), "Want to learn? Well read some of our History books", 45.0, new DateTime(2024, 4, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6508), "Book worm" },
                    { new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12"), true, new DateTime(2024, 5, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6501), "Bored? Well do we have some excitement for you, right now we are running a special campain to get that excitement back into peoples lifes", 100.0, new DateTime(2024, 4, 12, 13, 33, 27, 980, DateTimeKind.Local).AddTicks(6497), "Fantasy Hype" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ed24e676-706b-4900-aca3-64447375bc0f", "90c6b1e4-4c51-42a1-8a87-74c1d0de041f" },
                    { "380030f1-cc81-420d-af3d-6b057ce258a6", "a53c8fb9-e56c-4cd3-9aa7-23ba6cf5c59f" },
                    { "9b035ccf-ffd1-438a-be8f-83bacfe4bace", "b9eae165-e18c-48a9-832f-f8e48a448beb" },
                    { "9b035ccf-ffd1-438a-be8f-83bacfe4bace", "c14a84f5-ee67-4c8b-a633-5b2c041a5f5d" },
                    { "ed24e676-706b-4900-aca3-64447375bc0f", "c1672b48-42c0-4439-8038-eb275ef7863f" }
                });

            migrationBuilder.InsertData(
                table: "EBookSubscriptions",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("0cb91807-7ca5-433d-b843-a1b5fdd12cf6"), new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") },
                    { new Guid("207a4aab-ffd0-4fa3-a17f-ac65a5199b99"), new Guid("54f8d4fa-09e6-45f0-81e1-f98876852b76"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") },
                    { new Guid("5f970849-652e-439f-88b9-bc6952affa89"), new Guid("42fb8e87-42b8-4b37-a8f8-302c0dcbbdf1"), new Guid("633a99f4-122f-43b6-a815-1793d3b1d1d8") },
                    { new Guid("603dcdf6-9679-4a83-aa32-c4571be457b3"), new Guid("ac71b766-9c44-423f-9c17-c1b81f0b7d73"), new Guid("ad62eb17-501c-431c-84fb-541a76d623c5") },
                    { new Guid("75f342fb-13cf-46ac-aa97-ef93afa867b8"), new Guid("8b8a39ec-006b-43c0-975f-b0c91e7ad5ce"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") },
                    { new Guid("8ad2f863-1b48-4b39-ab85-1e6d2e2f85f6"), new Guid("0fbc59e2-5f35-4da2-be03-84da515f2cab"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") },
                    { new Guid("bed8f677-0372-4784-b577-52ffda38e0cf"), new Guid("a28d4719-c5c9-4240-a025-e350c9bd722a"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") },
                    { new Guid("f4ad3e10-8ce5-452e-9533-0781cc5a2091"), new Guid("bc5e4e13-ac1c-485c-8255-7619296e633f"), new Guid("ad62eb17-501c-431c-84fb-541a76d623c5") }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1"), "b9eae165-e18c-48a9-832f-f8e48a448beb", "Buster Nordic" },
                    { new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147"), "c14a84f5-ee67-4c8b-a633-5b2c041a5f5d", "Forlaget Mellemgaard" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8"), "c1672b48-42c0-4439-8038-eb275ef7863f" },
                    { new Guid("af4119b4-352f-4690-98ef-cf576b0400db"), "90c6b1e4-4c51-42a1-8a87-74c1d0de041f" }
                });

            migrationBuilder.InsertData(
                table: "EBookPublishers",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubPublisherPublisherID" },
                values: new object[,]
                {
                    { new Guid("2ab15c60-5c39-4c9d-8844-1f61e8e1d5c4"), new Guid("54f8d4fa-09e6-45f0-81e1-f98876852b76"), new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1") },
                    { new Guid("51a021e8-5023-4aeb-a083-29e31ba7aaee"), new Guid("8b8a39ec-006b-43c0-975f-b0c91e7ad5ce"), new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1") },
                    { new Guid("698e0807-ffc0-42de-880f-989a4d29b854"), new Guid("0fbc59e2-5f35-4da2-be03-84da515f2cab"), new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147") },
                    { new Guid("78d5b52a-ff81-4c6c-b596-e85b5c810fb1"), new Guid("bc5e4e13-ac1c-485c-8255-7619296e633f"), new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147") },
                    { new Guid("8e61b2e7-3301-42e1-a993-4166ac0f8dab"), new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"), new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1") },
                    { new Guid("ae91fdfb-e35f-4713-9695-75bc94a298e0"), new Guid("a28d4719-c5c9-4240-a025-e350c9bd722a"), new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1") },
                    { new Guid("fb90970e-a3bf-45e0-88d8-8671fe6ad762"), new Guid("42fb8e87-42b8-4b37-a8f8-302c0dcbbdf1"), new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147") }
                });

            migrationBuilder.InsertData(
                table: "EBookReaders",
                columns: new[] { "ID", "PubHubEBookEBookID", "PubHubReaderReaderID" },
                values: new object[,]
                {
                    { new Guid("536f5175-69cf-47dd-bc73-e4319083673a"), new Guid("54f8d4fa-09e6-45f0-81e1-f98876852b76"), new Guid("af4119b4-352f-4690-98ef-cf576b0400db") },
                    { new Guid("76338351-e6b0-441d-8aee-cf248b24c2b9"), new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"), new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8") },
                    { new Guid("7b328cc8-1136-4757-834e-d5af639e1122"), new Guid("ac71b766-9c44-423f-9c17-c1b81f0b7d73"), new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8") },
                    { new Guid("b153534b-b9c2-4e29-8809-5a4bffd453a7"), new Guid("8b8a39ec-006b-43c0-975f-b0c91e7ad5ce"), new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8") },
                    { new Guid("b286b342-bd31-4765-8fe7-50e585956036"), new Guid("bb232250-81a7-4547-a239-e7c75206a7b1"), new Guid("af4119b4-352f-4690-98ef-cf576b0400db") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPublishers",
                columns: new[] { "ID", "PubHubPublisherPublisherID", "PubHubSubscriptionSubscriptionID" },
                values: new object[,]
                {
                    { new Guid("4c0a86b0-6146-45da-bb3d-3468597b56d0"), new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147"), new Guid("633a99f4-122f-43b6-a815-1793d3b1d1d8") },
                    { new Guid("8b59f7b1-cb20-4f8e-aa58-f959549d3273"), new Guid("9dd4620b-e9f4-48fa-bf2c-272fa67e8147"), new Guid("ad62eb17-501c-431c-84fb-541a76d623c5") },
                    { new Guid("b5ea3011-03fd-4738-9ffa-cb03cd7b8e54"), new Guid("9d05a58f-f8b7-44ce-a296-701108cb68e1"), new Guid("d2f96097-ccd7-4188-abdb-65558ae46a12") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionReaders",
                columns: new[] { "ID", "PubHubReaderReaderID", "PubHubSubscriptionSubscriptionID" },
                values: new object[] { new Guid("d118b27e-0196-4f1b-9b2d-bfaec34c66a2"), new Guid("6dbd34cb-8e2e-4bf6-bb00-9b4cb711a0e8"), new Guid("4256c227-591e-41af-b705-677b1502d37d") });
        }
    }
}
