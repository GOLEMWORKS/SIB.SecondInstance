using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedArticlesOnCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91e51210-4d19-4672-ae16-759acbe9b7d7", "3", "Moderator", "MODERATOR" },
                    { "cd58d210-400d-429d-8e2b-a9961dc993c0", "4", "Creator", "CREATOR" },
                    { "d27dab82-a301-4728-80cb-59f3f43f20b0", "2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "c20fe15a-d871-4e28-bc3f-04b715128945", new DateTime(2023, 12, 26, 0, 22, 56, 166, DateTimeKind.Local).AddTicks(7037), "AQAAAAIAAYagAAAAEKm2qptPCAUFCkHabIvtg9vVzX/qZR+Vt8WVdK7r73w0w0xAC4GMZfP/RXCYBaKVFw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91e51210-4d19-4672-ae16-759acbe9b7d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd58d210-400d-429d-8e2b-a9961dc993c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d27dab82-a301-4728-80cb-59f3f43f20b0");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
