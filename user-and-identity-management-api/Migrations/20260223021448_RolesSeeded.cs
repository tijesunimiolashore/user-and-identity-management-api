using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace userandidentitymanagementapi.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "049ecb6b-113f-4e73-be1b-6d147c15a272", "3", "HR", "HR" },
                    { "4101fb24-6455-448c-8df5-f01d167733f6", "1", "Admin", "Admin" },
                    { "cb3419ae-e117-4394-82d2-6e626a8f0110", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "049ecb6b-113f-4e73-be1b-6d147c15a272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4101fb24-6455-448c-8df5-f01d167733f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb3419ae-e117-4394-82d2-6e626a8f0110");
        }
    }
}
