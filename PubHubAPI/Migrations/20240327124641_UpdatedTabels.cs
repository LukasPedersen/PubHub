using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PubHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_AspNetUsers_Id",
                table: "Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "MyPublisher",
                table: "EBooks");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Readers",
                newName: "MyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Readers_Id",
                table: "Readers",
                newName: "IX_Readers_MyUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publishers",
                newName: "MyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Publishers_Id",
                table: "Publishers",
                newName: "IX_Publishers_MyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_AspNetUsers_MyUserId",
                table: "Publishers",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readers_AspNetUsers_MyUserId",
                table: "Readers",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_AspNetUsers_MyUserId",
                table: "Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Readers_AspNetUsers_MyUserId",
                table: "Readers");

            migrationBuilder.RenameColumn(
                name: "MyUserId",
                table: "Readers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Readers_MyUserId",
                table: "Readers",
                newName: "IX_Readers_Id");

            migrationBuilder.RenameColumn(
                name: "MyUserId",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Publishers_MyUserId",
                table: "Publishers",
                newName: "IX_Publishers_Id");

            migrationBuilder.AddColumn<Guid>(
                name: "Publisher",
                table: "Subscriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MyPublisher",
                table: "EBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_AspNetUsers_Id",
                table: "Publishers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readers_AspNetUsers_Id",
                table: "Readers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
