using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class Createprebuildedowner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2806545e-f9d6-41fc-9288-c850ed4e236a", "2", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "1", "Owner", "OWNER" },
                    { "42b54096-c562-4103-b71a-b5359cd476be", "4", "Creator", "CREATOR" },
                    { "98ac59fc-c580-497a-a323-3f1888d57d12", "3", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfRegistration", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "ac1cc69b-9053-46b7-bdba-cc39640fe613", new DateTime(2023, 12, 20, 10, 11, 49, 281, DateTimeKind.Local).AddTicks(6112), "Owner@owner.com", true, false, null, "OWNER@OWNER.COM", "OWNER", "AQAAAAIAAYagAAAAEFX1R+ozGwfopoMCY7y/oMDCe8574l50i6Jw4z9kIgXfcqpNh6ehGr4yWnn9/Wv1GQ==", null, false, "01.01.0001 0:00:00", false, "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

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
    }
}
