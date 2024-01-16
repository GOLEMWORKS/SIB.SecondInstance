using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddingArticlesDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4542c9bc-8355-4cc8-a37f-7da5b8dbb9d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e47d9c4-d52a-4c74-8d27-a64af88d9a81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1accc7d-c9f7-4c5c-a668-f0e2763913b6");

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DOC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_articles_AspNetUsers_Author",
                        column: x => x.Author,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_articles_Author",
                table: "articles",
                column: "Author");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articles");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4542c9bc-8355-4cc8-a37f-7da5b8dbb9d3", "2", "Admin", "ADMIN" },
                    { "4e47d9c4-d52a-4c74-8d27-a64af88d9a81", "4", "Creator", "CREATOR" },
                    { "f1accc7d-c9f7-4c5c-a668-f0e2763913b6", "3", "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "33dae502-8d9b-40b1-820e-f2396ed80dfd", new DateTime(2023, 12, 20, 10, 32, 24, 72, DateTimeKind.Local).AddTicks(1213), "AQAAAAIAAYagAAAAEE23QOYuGXSvEZp+c66s1kmbLiy9ofXG7QtSR+APu5nmjbMbOwjTUvGBbt9LNAyhzg==" });
        }
    }
}
