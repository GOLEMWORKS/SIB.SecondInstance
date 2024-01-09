using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreatePrebuildUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418471dc-88a8-4349-ad96-9e7686e8e8a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c1b1e9c-58dd-45ba-8229-776fb34feb05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c5106a-f3ac-4492-9019-0b0195885074");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daa6d472-4d71-4f32-9558-62e271aaa1a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "554803e3-31ea-4104-8371-d02147b3a3e3", "2", "Admin", "ADMIN" },
                    { "d699e126-32fd-40a9-95e4-51797bc1f6e9", "3", "Moderator", "MODERATOR" },
                    { "e63e3f91-bbcb-493a-b391-af5b8f5ced08", "1", "Owner", "OWNER" },
                    { "f6d185c3-8b98-4fb6-972e-a6f801c8d298", "4", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfRegistration", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0354aed4-4475-4182-8b27-cb68b41a6b45", 0, "b1a0c6a7-b4a5-4ed2-9525-82a08013ef16", new DateTime(2023, 12, 20, 10, 3, 26, 612, DateTimeKind.Local).AddTicks(8488), "Owner@owner.com", true, false, null, "OWNER@OWNER.COM", "OWNER", "AQAAAAIAAYagAAAAEEFxE8sGhwTWcUUGeYTJN3vVjCH8hD9Ah+LtvDTNxDwic2dW98VIXttQt8PrPDUPOw==", null, false, "01.01.0001 0:00:00", false, "Owner" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "554803e3-31ea-4104-8371-d02147b3a3e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d699e126-32fd-40a9-95e4-51797bc1f6e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e63e3f91-bbcb-493a-b391-af5b8f5ced08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6d185c3-8b98-4fb6-972e-a6f801c8d298");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0354aed4-4475-4182-8b27-cb68b41a6b45");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "418471dc-88a8-4349-ad96-9e7686e8e8a8", "1", "Owner", "OWNER" },
                    { "5c1b1e9c-58dd-45ba-8229-776fb34feb05", "4", "Creator", "CREATOR" },
                    { "a2c5106a-f3ac-4492-9019-0b0195885074", "3", "Moderator", "MODERATOR" },
                    { "daa6d472-4d71-4f32-9558-62e271aaa1a6", "2", "Admin", "ADMIN" }
                });
        }
    }
}
