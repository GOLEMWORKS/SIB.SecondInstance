using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameArticlesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_AspNetUsers_Author",
                table: "articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_articles",
                table: "articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65d7fdb7-1ad2-4e1a-bd39-b2e04b106f06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ff00ab-147e-439f-b80b-a0fedba7d832");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a4da1c2-5a44-4549-a5b0-3c07d20226b3");

            migrationBuilder.RenameTable(
                name: "articles",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_articles_Author",
                table: "Articles",
                newName: "IX_Articles_Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_Author",
                table: "Articles",
                column: "Author",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_Author",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
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

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "articles");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_Author",
                table: "articles",
                newName: "IX_articles_Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_articles",
                table: "articles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65d7fdb7-1ad2-4e1a-bd39-b2e04b106f06", "4", "Creator", "CREATOR" },
                    { "79ff00ab-147e-439f-b80b-a0fedba7d832", "3", "Moderator", "MODERATOR" },
                    { "8a4da1c2-5a44-4549-a5b0-3c07d20226b3", "2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "f8753047-086c-441e-a267-c5df9fcd8f76", new DateTime(2023, 12, 25, 21, 43, 26, 288, DateTimeKind.Local).AddTicks(227), "AQAAAAIAAYagAAAAELne6PBrCpX+yg8nmWS1iboEZo4i54HdALMyjY57J4EIBuj3m4AOaWo9XLQjVst/IQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_articles_AspNetUsers_Author",
                table: "articles",
                column: "Author",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
