using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PubHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Readers",
                table: "Readers");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Readers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PubHubUserId",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Readers",
                table: "Readers",
                column: "ReaderID");

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                    table.ForeignKey(
                        name: "FK_Publishers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    Publisher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    PubHubPublisherPublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PubHubReaderReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Publishers_PubHubPublisherPublisherID",
                        column: x => x.PubHubPublisherPublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID");
                    table.ForeignKey(
                        name: "FK_Subscriptions_Readers_PubHubReaderReaderID",
                        column: x => x.PubHubReaderReaderID,
                        principalTable: "Readers",
                        principalColumn: "ReaderID");
                });

            migrationBuilder.CreateTable(
                name: "EBooks",
                columns: table => new
                {
                    EBookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MyPublisher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadCount = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BorrowPrice = table.Column<double>(type: "float", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PubHubPublisherPublisherID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PubHubReaderReaderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PubHubSubscriptionSubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBooks", x => x.EBookID);
                    table.ForeignKey(
                        name: "FK_EBooks_Publishers_PubHubPublisherPublisherID",
                        column: x => x.PubHubPublisherPublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID");
                    table.ForeignKey(
                        name: "FK_EBooks_Readers_PubHubReaderReaderID",
                        column: x => x.PubHubReaderReaderID,
                        principalTable: "Readers",
                        principalColumn: "ReaderID");
                    table.ForeignKey(
                        name: "FK_EBooks_Subscriptions_PubHubSubscriptionSubscriptionID",
                        column: x => x.PubHubSubscriptionSubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Readers_Id",
                table: "Readers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_PubHubUserId",
                table: "AspNetRoles",
                column: "PubHubUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_PubHubPublisherPublisherID",
                table: "EBooks",
                column: "PubHubPublisherPublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_PubHubReaderReaderID",
                table: "EBooks",
                column: "PubHubReaderReaderID");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_PubHubSubscriptionSubscriptionID",
                table: "EBooks",
                column: "PubHubSubscriptionSubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_Id",
                table: "Publishers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PubHubPublisherPublisherID",
                table: "Subscriptions",
                column: "PubHubPublisherPublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PubHubReaderReaderID",
                table: "Subscriptions",
                column: "PubHubReaderReaderID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_PubHubUserId",
                table: "AspNetRoles",
                column: "PubHubUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_PubHubUserId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers");

            migrationBuilder.DropTable(
                name: "EBooks");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Readers",
                table: "Readers");

            migrationBuilder.DropIndex(
                name: "IX_Readers_Id",
                table: "Readers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_PubHubUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PubHubUserId",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Readers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Readers",
                table: "Readers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
