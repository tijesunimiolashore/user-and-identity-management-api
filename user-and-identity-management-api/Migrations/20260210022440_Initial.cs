using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace userandidentitymanagementapi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ab23043-6322-467e-a0cf-a34a53f3f47a", "2", "User", "User" },
                    { "9d3782df-1bf8-4283-a1b8-9067163b6257", "1", "Admin", "Admin" },
                    { "f027ee6c-f5f0-4407-921b-497576aef22e", "3", "sdk", "sdk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ab23043-6322-467e-a0cf-a34a53f3f47a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3782df-1bf8-4283-a1b8-9067163b6257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f027ee6c-f5f0-4407-921b-497576aef22e");
        }
    }
}
