using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubHubWebServer.Migrations
{
    /// <inheritdoc />
    public partial class UserPublisherReaderBooksDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "827d7ed4-9a22-4b6b-aeb8-6919a672bedc");

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("55b8ac25-a197-4a0b-9cd7-2cd0757d4bb7"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("a5e7136a-629f-4921-b5d9-83d674c341bd"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("2cc99d57-3963-4d76-8d07-3e3a8d79a615"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("3a899400-48de-4672-9c79-a975230bb1d8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0ac36a6-d5a1-4810-8d3d-14bf2acb7fb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3edbc03-221d-4057-a1a4-ebb950122785");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f097dc4b-e443-4256-bd76-10514f549836");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd0c4ce7-d5e2-451a-acc9-3b04dce524e0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1921f6ae-86bf-4581-b6b7-cccfd94157b1", 0, true, "9b8fdbf6-ed5a-4b82-aaf4-dd4d5e080d52", "ApplicationUser", "Mellemgaard@hotmail.com", false, false, null, new Guid("01e6a853-9ed8-4616-8866-1e5244ff240f"), "MELLEMGAARD@HOTMAIL.COM", "FORLAGET MELLEMGAARD", "AQAAAAIAAYagAAAAEEmqQe/vndhXqRlDxRsxGHAX1kuWQ117TY6XF/XEO905889tcX+x5AeDq4eyXySWEQ==", null, false, "TBBRBHXVDKL4JYRX5YZLFTX56P76CYKO", false, "Forlaget Mellemgaard" },
                    { "2932e86c-ddf9-4403-a664-7729a9c8b865", 0, true, "e82c37ba-22be-4f0a-ac8b-23a62c11476a", "ApplicationUser", "lukas3302@hotmail.com", false, false, null, new Guid("d3f64447-bed3-44fb-879e-c989eb81ede0"), "LUKAS3302@HOTMAIL.COM", "LUKAS", "AQAAAAIAAYagAAAAEPsl/YnmLOop8Q3eHEXfKy0CTTI7Vpm2pWEn64idVqozxtLVvtcr4Uf1iyRbshmsIw==", null, false, "GLY234PA27LVMGEQEBJERG7KGRXQSRDU", false, "Lukas Pedersen" },
                    { "3fcb39c1-5da6-4a09-8383-a7850ecfd6b2", 0, true, "d317d42c-6ab7-4ece-b9c4-4210d3c2f009", "ApplicationUser", "Jens2837@hotmail.com", false, false, null, new Guid("094e390b-2c8f-4e71-9660-e491993d2b14"), "JENS2837@HOTMAIL.COM", "JENS ANKER", "AQAAAAIAAYagAAAAEH5hcJHlyO7YeqMGmZqDju46u5EHka/NiKKqqJHKpbq3jEiI5UT1tsVlUp4ziDa+5Q==", null, false, "FT4UX4Y6TUBDTMWYUAIVE622QJ6GHBOG", false, "Jens Anker" },
                    { "74fd6a7a-0b9b-4540-bd86-3f2f59ecdbfa", 0, true, "653cb2db-6f92-4eda-8288-ec972843ad9d", "ApplicationUser", "Nordic@hotmail.com", false, false, null, new Guid("f07370a6-780f-426f-833f-182a1ede9304"), "NORDIC@HOTMAIL.COM", "BUSTER NORDIC", "AQAAAAIAAYagAAAAEKpF63VYci9tx6jT7M6RwfqLpgvmA5W8iFFOyOVJZsXZ+5ozXHv+vVhSZ4iBWDHRDA==", null, false, "NQUEGF4VUUD7QGUA4XP5YNMDMLT5US6H", false, "Buster Nordic" },
                    { "8c50d7e9-0cef-4b33-a2e3-002375b85dc2", 0, true, "a4d4b000-df14-4c3e-9f89-73a90c4a8584", "ApplicationUser", "Admin@hotmail.com", false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEI7YCzKIQOnqgMycVwCJ/45d4njC5tjma1AFeC1Z/YuJ2ZD91x+B90FvXluwB3qZvw==", null, false, "GP4QLQ2ZVJJBYBHBQLLGP4G22UJJFH4U", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "EBookID", "AuthorNames", "BorrowPrice", "Description", "DownloadCount", "FilePath", "Genre", "PageCount", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("13bc304c-5e54-47e0-9f6e-a4bfd4f14412"), "Charlotte M. Yonge", 21.949999999999999, "This book has been considered by academicians and scholars of great significance and value to literature. This forms a part of the knowledge base for future generations. We havent used any OCR or photocopy to produce this book. The whole book has been typeset again to produce it without any errors or poor pictures and errant marks.", 0L, "History-of-France", "History", 78, 89.0, "History of France" },
                    { new Guid("485b92db-4fc2-49e6-bb0e-dde12042dd35"), "Gustave Aimard", 27.0, "This work has been selected by scholars as being culturally important, and is part of the knowledge base of civilization as we know it. This work was reproduced from the original artifact, and remains as true to the original work as possible. Therefore, you will see the original copyright references, library stamps (as most of these works have been housed in our most important libraries around the world), and other notations in the work.This work is in the public domain in the United States of America, and possibly other nations. Within the United States, you may freely copy and distribute this work, as no entity (individual or corporate) has a copyright on the body of the work.As a reproduction of a historical artifact, this work may contain missing or blurred pages, poor pictures, errant marks, etc. Scholars believe, and we concur, that this work is important enough to be preserved, reproduced, and made generally available to the public. We appreciate your support of the preservation process, and thank you for being an important part of keeping this knowledge alive and relevant.", 0L, "The-Pirates-of-the-Prairies-Adventures-in-the-American-Desert", "History", 250, 89.950000000000003, "The Pirates of the Prairies: Adventures in the American Desert" },
                    { new Guid("66666e12-98aa-40d9-b1cd-5977e40e6002"), "Charlotte M. Yonge", 65.950000000000003, "Richard I (28 August 933 – 20 November 996), also known as Richard the Fearless (French, Richard Sans-Peur), was the Count of Rouen from 942 to 996. Dudo of Saint-Quentin, whom Richard commissioned to write the \"De moribus et actis primorum Normanniae ducum\" (Latin, \"On the Customs and Deeds of the First Dukes of Normandy\"), called him a Dux.", 0L, "The-Little-Duke-Richard-the-Fearless", "History", 145, 130.94999999999999, "The Little Duke: Richard the Fearless" },
                    { new Guid("6ccbb8a7-1472-4395-8834-4179c3ec13e4"), "Gustave Aimard", 89.950000000000003, "\"The Flying Horseman\" is a thrilling tale penned by the French writer Gustave Aimard. Set in a world of adventure and danger, the story follows the journey of its titular character as he navigates challenges and confronts adversaries. With its gripping narrative and rich character development, this classic work is a testament to Aimard's literary genius.", 0L, "", "Thriller French Adventure", 166, 299.94999999999999, "The Flying Horseman" },
                    { new Guid("7b6bb5f6-0238-4304-8508-6e9b130a6bc6"), "Charlotte M. Yonge", 34.0, "First published in 1853, The Heir of Redclyffe was the most successful novel of the century. Adopted by William Morris and Burne-Jones \"as a pattern for life,\" the protagonist, Guy, was a popular role model of noble virtue, while another character, Amy, was seen as the ideal Victorian wife--redeemer and inspirer, supporter and guide. This novel is a virtual paradigm of the trends of thought which marked the middle decades of the nineteenth-century. It is also deeply marked by the influence of the Oxford Movement, an aspect explored in Barbara Dennis's Introduction to this unique critical edition.", 0L, "The-Heir-of-Redclyffe", "Romance novel", 637, 170.0, "The Heir of Redclyffe" },
                    { new Guid("9dfe7001-ff62-49c2-a119-20a8551aca67"), "Gustave Aimard", 43.0, "Opening with loading a ship in Cape Horn, Chile, the book takes readers on an adventure throughout South America. Encounters with indigenous populations and learning to find common ground with others are at the heart of this tale, in many ways mirroring the author's own experiences.", 0L, "", "Fiction Adventure", 190, 206.94999999999999, "The Guide of the Desert" },
                    { new Guid("a6a236ed-7b6b-4159-9e1e-10572be599ef"), "Gustave Aimard", 45.0, "The Pearl of the Andes A Tale of Love and Adventure, a classical book, has been considered important throughout the human history, and so that this work is never forgotten we at Alpha Editions have made efforts in its preservation by republishing this book in a modern format for present and future generations. This whole book has been reformatted, retyped and designed. These books are not made of scanned copies of their original work and hence the text is clear and readable.", 0L, "The-Pearl-of-the-Andes-A-Tale-of-Love-and-Adventure", "Fantasy Adventure Romance Fiction", 205, 111.0, "The Pearl of the Andes A Tale of Love and Adventure" },
                    { new Guid("c2571b34-63d0-4faf-ac49-1d177a4a22c8"), "Gustave Aimard", 45.0, "Gustave Aimard, seudónimo de Olivier Groux (1818-1883), fue un novelista francés. Abandonado al nacer por sus padres, de espíritu rebelde, no aceptó a la pareja que lo adoptó y a los nueve años escapó de la casa y marchó a América del Sur. Posteriormente se trasladó a Estados Unidos, donde convivió con los cheyennes. De vuelta la Europa en 1847 viajó por España, Turquía y el Cáucaso. En 1852 volvió a América, pero en 1854 regresó definitivamente a Francia y comenzó a escribir a partir de 1856. Sus experiencias le sirvieron para escribir numerosas novelas del oeste que se hicieron muy populares en Francia y Estados Unidos.", 0L, "Las-noches-mejicanas", "Thriller Adventure Fiction", 240, 159.94999999999999, "Las noches mejicanas" },
                    { new Guid("cafd2842-51d6-4bd5-9a6c-08c4aa665cc9"), "Gustave Aimard", 51.0, "\"The Smuggler Chief\" is a thrilling adventure story penned by French writer Gustave Aimard and translated by Lascelles Sir Wraxall. Set against a backdrop of danger and intrigue, the novel follows the lives of smugglers, exploring themes of loyalty, betrayal, and the quest for freedom. Aimard's vivid storytelling and rich characterization make this a must-read for fans of classic adventure tales.", 0L, "The-Smuggler-Chief", "Thriller Adventure Fiction", 105, 171.0, "The Smuggler Chief" },
                    { new Guid("d5f45ec5-110e-4be6-9f85-70d864307cf3"), "Gustave Aimard", 55.0, "The action and adventure genre in fiction depicts events or a series of events that happen outside the ordinary course of the protagonist's daily life, generally accompanied by dangerous episodes and physical action. Adventure stories are quick moving, with the pace of the plot being a critical component of mood setting. Action and adventure have been common book themes since the earliest days of fiction writing. In fact, the plots of Medieval romances were comprised of a series of adventures. Action / adventure fiction often overlaps with other genres, such as: war novels, crime novels, sea stories, Robinsonades, and spy stories.", 0L, "The-Bee-Hunters-A-Tale-of-Adventure", "Action Adventure Fiction", 240, 132.94999999999999, "The Bee Hunters: A Tale of Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("01e6a853-9ed8-4616-8866-1e5244ff240f"), "1921f6ae-86bf-4581-b6b7-cccfd94157b1", "Forlaget Mellemgaard" },
                    { new Guid("f07370a6-780f-426f-833f-182a1ede9304"), "74fd6a7a-0b9b-4540-bd86-3f2f59ecdbfa", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("094e390b-2c8f-4e71-9660-e491993d2b14"), "3fcb39c1-5da6-4a09-8383-a7850ecfd6b2" },
                    { new Guid("d3f64447-bed3-44fb-879e-c989eb81ede0"), "2932e86c-ddf9-4403-a664-7729a9c8b865" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c50d7e9-0cef-4b33-a2e3-002375b85dc2");

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("13bc304c-5e54-47e0-9f6e-a4bfd4f14412"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("485b92db-4fc2-49e6-bb0e-dde12042dd35"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("66666e12-98aa-40d9-b1cd-5977e40e6002"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("6ccbb8a7-1472-4395-8834-4179c3ec13e4"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("7b6bb5f6-0238-4304-8508-6e9b130a6bc6"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("9dfe7001-ff62-49c2-a119-20a8551aca67"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("a6a236ed-7b6b-4159-9e1e-10572be599ef"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("c2571b34-63d0-4faf-ac49-1d177a4a22c8"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("cafd2842-51d6-4bd5-9a6c-08c4aa665cc9"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "EBookID",
                keyValue: new Guid("d5f45ec5-110e-4be6-9f85-70d864307cf3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("01e6a853-9ed8-4616-8866-1e5244ff240f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: new Guid("f07370a6-780f-426f-833f-182a1ede9304"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("094e390b-2c8f-4e71-9660-e491993d2b14"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "ReaderID",
                keyValue: new Guid("d3f64447-bed3-44fb-879e-c989eb81ede0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1921f6ae-86bf-4581-b6b7-cccfd94157b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2932e86c-ddf9-4403-a664-7729a9c8b865");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fcb39c1-5da6-4a09-8383-a7850ecfd6b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74fd6a7a-0b9b-4540-bd86-3f2f59ecdbfa");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyPubHubAccount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "827d7ed4-9a22-4b6b-aeb8-6919a672bedc", 0, true, "a4d4b000-df14-4c3e-9f89-73a90c4a8584", "ApplicationUser", "Admin@hotmail.com", false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "ADMIN@HOTMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEI7YCzKIQOnqgMycVwCJ/45d4njC5tjma1AFeC1Z/YuJ2ZD91x+B90FvXluwB3qZvw==", null, false, "GP4QLQ2ZVJJBYBHBQLLGP4G22UJJFH4U", false, "Admin" },
                    { "b0ac36a6-d5a1-4810-8d3d-14bf2acb7fb7", 0, true, "9b8fdbf6-ed5a-4b82-aaf4-dd4d5e080d52", "ApplicationUser", "Mellemgaard@hotmail.com", false, false, null, new Guid("55b8ac25-a197-4a0b-9cd7-2cd0757d4bb7"), "MELLEMGAARD@HOTMAIL.COM", "FORLAGET MELLEMGAARD", "AQAAAAIAAYagAAAAEEmqQe/vndhXqRlDxRsxGHAX1kuWQ117TY6XF/XEO905889tcX+x5AeDq4eyXySWEQ==", null, false, "TBBRBHXVDKL4JYRX5YZLFTX56P76CYKO", false, "Forlaget Mellemgaard" },
                    { "b3edbc03-221d-4057-a1a4-ebb950122785", 0, true, "e82c37ba-22be-4f0a-ac8b-23a62c11476a", "ApplicationUser", "lukas3302@hotmail.com", false, false, null, new Guid("3a899400-48de-4672-9c79-a975230bb1d8"), "LUKAS3302@HOTMAIL.COM", "LUKAS", "AQAAAAIAAYagAAAAEPsl/YnmLOop8Q3eHEXfKy0CTTI7Vpm2pWEn64idVqozxtLVvtcr4Uf1iyRbshmsIw==", null, false, "GLY234PA27LVMGEQEBJERG7KGRXQSRDU", false, "Lukas Pedersen" },
                    { "f097dc4b-e443-4256-bd76-10514f549836", 0, true, "d317d42c-6ab7-4ece-b9c4-4210d3c2f009", "ApplicationUser", "Jens2837@hotmail.com", false, false, null, new Guid("2cc99d57-3963-4d76-8d07-3e3a8d79a615"), "JENS2837@HOTMAIL.COM", "JENS ANKER", "AQAAAAIAAYagAAAAEH5hcJHlyO7YeqMGmZqDju46u5EHka/NiKKqqJHKpbq3jEiI5UT1tsVlUp4ziDa+5Q==", null, false, "FT4UX4Y6TUBDTMWYUAIVE622QJ6GHBOG", false, "Jens Anker" },
                    { "fd0c4ce7-d5e2-451a-acc9-3b04dce524e0", 0, true, "653cb2db-6f92-4eda-8288-ec972843ad9d", "ApplicationUser", "Nordic@hotmail.com", false, false, null, new Guid("a5e7136a-629f-4921-b5d9-83d674c341bd"), "NORDIC@HOTMAIL.COM", "BUSTER NORDIC", "AQAAAAIAAYagAAAAEKpF63VYci9tx6jT7M6RwfqLpgvmA5W8iFFOyOVJZsXZ+5ozXHv+vVhSZ4iBWDHRDA==", null, false, "NQUEGF4VUUD7QGUA4XP5YNMDMLT5US6H", false, "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { new Guid("55b8ac25-a197-4a0b-9cd7-2cd0757d4bb7"), "b0ac36a6-d5a1-4810-8d3d-14bf2acb7fb7", "Forlaget Mellemgaard" },
                    { new Guid("a5e7136a-629f-4921-b5d9-83d674c341bd"), "fd0c4ce7-d5e2-451a-acc9-3b04dce524e0", "Buster Nordic" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "ReaderID", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("2cc99d57-3963-4d76-8d07-3e3a8d79a615"), "f097dc4b-e443-4256-bd76-10514f549836" },
                    { new Guid("3a899400-48de-4672-9c79-a975230bb1d8"), "b3edbc03-221d-4057-a1a4-ebb950122785" }
                });
        }
    }
}
