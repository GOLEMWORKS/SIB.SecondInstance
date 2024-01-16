using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_Author",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_Author",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f3ff046-0cd0-4e3a-a409-9d25b99038a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "518f4851-a10c-4ea3-a7fa-f89effdcd00c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce4b7dbb-b2c4-4499-943c-f8e7d29b8ffc");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "191cfc5d-0532-4954-bce6-12ff8d16ad5d", "3", "Moderator", "MODERATOR" },
                    { "86a10a02-9095-4d7b-bee3-23656a2ea858", "2", "Admin", "ADMIN" },
                    { "e3a396a7-845b-430a-bfd9-556156854319", "4", "Creator", "CREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "934799a2-ced5-4c92-be47-5d9ad710f9b1", new DateTime(2023, 12, 26, 0, 17, 49, 386, DateTimeKind.Local).AddTicks(5290), "AQAAAAIAAYagAAAAEMytkkJ6h9CAiGP7As3I/lZKIlkwfNlGeOnpK1pNH8XjSmBsjNXKXtTV/zKsj9A+5A==" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "191cfc5d-0532-4954-bce6-12ff8d16ad5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86a10a02-9095-4d7b-bee3-23656a2ea858");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a396a7-845b-430a-bfd9-556156854319");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f3ff046-0cd0-4e3a-a409-9d25b99038a3", "2", "Admin", "ADMIN" },
                    { "518f4851-a10c-4ea3-a7fa-f89effdcd00c", "3", "Moderator", "MODERATOR" },
                    { "ce4b7dbb-b2c4-4499-943c-f8e7d29b8ffc", "4", "Creator", "CREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "e31fc0bd-f944-49bd-a1e6-cc433d71f551", new DateTime(2023, 12, 25, 21, 46, 17, 386, DateTimeKind.Local).AddTicks(9222), "AQAAAAIAAYagAAAAEMiXENx1A857BX5fNPZHBSNZ4jfQhhZMXN5qWezBy7/Bsy4Rbi+BfAeu9UCDfeMOZQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Author",
                table: "Articles",
                column: "Author");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_Author",
                table: "Articles",
                column: "Author",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
