using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class AddAvailableToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", "063a2e71-c5c3-490a-8731-d08e25ca43c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", "1edb2bf3-4c3d-4b94-8d0c-3a18dc159fcd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad", "29edea6b-5e1a-48d9-bf42-d52572e49ef4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bee65b2-7f7c-42b2-8051-b2e4bf57e556", "84f5ddc8-55dc-4d4e-9b06-b263bde5305c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9442baa8-756a-4c8c-bff2-122126d10ea9", "f9121407-b145-4cfe-a970-3f23e946e292" });

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("08d54c14-b0e0-4ac1-9419-ca1e7b098444"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("10e1f648-739b-4520-aae3-02aa966dd721"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("4d0299fe-9c4e-445a-bd38-f750412ef874"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("5fe56dae-3eb3-48db-bc0c-a9cfad8188b6"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("7a4438b6-bccf-481b-87d8-342426bf1d8e"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("905b3e6d-9415-41e7-829d-392efae0a8df"));

            migrationBuilder.DeleteData(
                table: "EBookPublishers",
                keyColumn: "ID",
                keyValue: new Guid("bc3c5b75-3089-4a43-bcad-ebe20f1ea3d8"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("816242e5-6633-4428-9cf1-31a2b497c672"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("a7283004-ba59-493a-aa23-bab3d73b9117"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("bac4aa3b-9a0e-4f11-8f57-9c62cb9be626"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("d5a795ac-a51c-4010-a50d-f53f81851935"));

            migrationBuilder.DeleteData(
                table: "EBookReaders",
                keyColumn: "ID",
                keyValue: new Guid("e02c6357-4580-492b-9d05-675bdb807ceb"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("10520693-a97b-4e42-9f02-9693912ebc75"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("3c45f386-feb5-4415-b54f-54f2803a809f"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("3e9a790f-5ee2-40dc-a6cf-000ea797d1b2"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("747e8919-ed74-4185-b905-79c392bcb485"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("95d0905f-406e-4ebd-905d-f408e1cc4a9e"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("a0879660-ceca-430a-ba53-5afd83b06a21"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("b63fe173-1463-469b-8dd6-5c0d8198939b"));

            migrationBuilder.DeleteData(
                table: "EBookSubscriptions",
                keyColumn: "ID",
                keyValue: new Guid("d304700d-5f7f-495d-a6f5-1d5cce5f9dd4"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("999632dc-9e92-48ed-970b-2d442c956e14"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("a7d23c05-cf52-4bd0-8afe-7deab009bb96"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPublishers",
                keyColumn: "ID",
                keyValue: new Guid("b2747f3e-c2ee-478f-9b08-5a34ee8a5d54"));

            migrationBuilder.DeleteData(
                table: "SubscriptionReaders",
                keyColumn: "ID",
                keyValue: new Guid("4e0e24de-d69d-48aa-a215-d40dadc45052"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fae5ef2-2cc8-4b81-99c9-6b3c480682ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9442baa8-756a-4c8c-bff2-122126d10ea9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bee65b2-7f7c-42b2-8051-b2e4bf57e556");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9121407-b145-4cfe-a970-3f23e946e292");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("34630099-f790-46bd-b3a2-ffcbc4098031"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("37a5c24b-5921-4a0a-bfdc-1a86c7950091"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("b8c9d2f6-9ec9-431a-badb-6f81d46c2ad0"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c339e5e0-3e68-4b02-b4ed-ab2078646234"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c88b4604-8d86-456f-ac5f-343e194c81f0"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c8b5140e-6fb4-4a30-8f49-859c7012f45e"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c92d3f7c-7443-4590-a408-62777bbf242e"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("d210234b-f17d-4afe-b440-ba78aad861ea"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("1341f585-101b-48e0-bfdd-b38c2e2d72fe"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("8848bded-4306-4443-9962-d8e84ae802ef"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("8ea44d2d-e537-4c75-a281-11ed24d52e14"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("ce3e6fa0-d2d3-48b8-82bc-7847f0198959"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("1b4b4c06-1bab-4234-950a-89a022df1b8a"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("5b63a52e-e1e5-4f99-8899-d3d12b6e879d"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("7a2eb4f8-b060-4f8c-af4f-9ff0a4ea464a"));

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "SubscriptionID",
                keyValue: new Guid("a03646e1-cef6-4c8b-b324-1289ee2caeb8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "063a2e71-c5c3-490a-8731-d08e25ca43c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1edb2bf3-4c3d-4b94-8d0c-3a18dc159fcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29edea6b-5e1a-48d9-bf42-d52572e49ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f5ddc8-55dc-4d4e-9b06-b263bde5305c");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "EBooks",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Available",
                table: "EBooks");

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
        }
    }
}
