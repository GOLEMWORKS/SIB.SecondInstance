using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateprebuildedownerFIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2806545e-f9d6-41fc-9288-c850ed4e236a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42b54096-c562-4103-b71a-b5359cd476be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98ac59fc-c580-497a-a323-3f1888d57d12");

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
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "33dae502-8d9b-40b1-820e-f2396ed80dfd", new DateTime(2023, 12, 20, 10, 32, 24, 72, DateTimeKind.Local).AddTicks(1213), "OWNER@OWNER.COM", "AQAAAAIAAYagAAAAEE23QOYuGXSvEZp+c66s1kmbLiy9ofXG7QtSR+APu5nmjbMbOwjTUvGBbt9LNAyhzg==", "Owner@owner.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2806545e-f9d6-41fc-9288-c850ed4e236a", "2", "Admin", "ADMIN" },
                    { "42b54096-c562-4103-b71a-b5359cd476be", "4", "Creator", "CREATOR" },
                    { "98ac59fc-c580-497a-a323-3f1888d57d12", "3", "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "ac1cc69b-9053-46b7-bdba-cc39640fe613", new DateTime(2023, 12, 20, 10, 11, 49, 281, DateTimeKind.Local).AddTicks(6112), "OWNER", "AQAAAAIAAYagAAAAEFX1R+ozGwfopoMCY7y/oMDCe8574l50i6Jw4z9kIgXfcqpNh6ehGr4yWnn9/Wv1GQ==", "Owner" });
        }
    }
}
