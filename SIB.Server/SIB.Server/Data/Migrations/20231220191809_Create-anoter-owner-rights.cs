using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class Createanoterownerrights : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02815899-3498-4e83-97ec-7f803c304521", "4", "Creator", "CREATOR" },
                    { "14438562-6693-44a8-b80e-6945f74f4ee8", "3", "Moderator", "MODERATOR" },
                    { "c77194b1-b6b0-4950-bb15-ca479b57c123", "2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "e5f6a138-2454-44b6-bead-ea1bf7b20ce0", new DateTime(2023, 12, 20, 21, 18, 6, 251, DateTimeKind.Local).AddTicks(5467), "AQAAAAIAAYagAAAAEH5lCVqmgyg4c4a6euCjpnLn2cTJiRlNP6t1lcnSnuemBDzRbByxQEo2zjoLiFz1pA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02815899-3498-4e83-97ec-7f803c304521");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14438562-6693-44a8-b80e-6945f74f4ee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c77194b1-b6b0-4950-bb15-ca479b57c123");

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
