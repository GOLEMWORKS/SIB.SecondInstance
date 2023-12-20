using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIB.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreatePrebuildRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
