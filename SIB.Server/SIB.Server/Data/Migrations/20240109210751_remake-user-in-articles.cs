using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class remakeuserinarticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "91e51210-4d19-4672-ae16-759acbe9b7d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd58d210-400d-429d-8e2b-a9961dc993c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d27dab82-a301-4728-80cb-59f3f43f20b0");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
