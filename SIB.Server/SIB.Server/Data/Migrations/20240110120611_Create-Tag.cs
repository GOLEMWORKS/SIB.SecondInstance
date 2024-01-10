using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d5965de-8754-4607-924e-b5968f6c2562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6911fddd-7b6f-4b3e-bf87-554d14c84ffe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69471c63-ba5a-44be-b1f3-7e83fcc2dc51");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b35306a-861c-4030-bd95-ed65cf4e35b9", "4", "Creator", "CREATOR" },
                    { "40cf8cfe-f396-4454-976e-281baa5e6504", "3", "Moderator", "MODERATOR" },
                    { "81d29205-1cb3-441f-9681-cf0bff8d4cb1", "2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "b27b6253-2240-4713-b566-4e63841d8d7f", new DateTime(2024, 1, 10, 14, 6, 10, 555, DateTimeKind.Local).AddTicks(6433), "AQAAAAIAAYagAAAAEN7UExwmOLePdsc3QPd7EknnUnlpilxm6ofcGnyIb0XTxyKKAEWedYYrxWPGV+SQLQ==" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Протоколы" },
                    { 2, null, "Структуры данных" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ArticleId",
                table: "Tags",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b35306a-861c-4030-bd95-ed65cf4e35b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40cf8cfe-f396-4454-976e-281baa5e6504");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81d29205-1cb3-441f-9681-cf0bff8d4cb1");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d5965de-8754-4607-924e-b5968f6c2562", "4", "Creator", "CREATOR" },
                    { "6911fddd-7b6f-4b3e-bf87-554d14c84ffe", "3", "Moderator", "MODERATOR" },
                    { "69471c63-ba5a-44be-b1f3-7e83fcc2dc51", "2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "d858d30a-4cd0-4fe3-b2a1-bbf4b4dd7eda", new DateTime(2024, 1, 9, 23, 7, 50, 772, DateTimeKind.Local).AddTicks(8959), "AQAAAAIAAYagAAAAEL3TTRqSFn/b7JfUdbtYd1mjbJJgVHU9wguPqizUd7YErDVtS2+pmzz8tiITn99crw==" });
        }
    }
}
