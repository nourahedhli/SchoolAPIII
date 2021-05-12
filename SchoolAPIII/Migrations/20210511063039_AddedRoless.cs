using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPIII.Migrations
{
    public partial class AddedRoless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2098a5ac-d882-4f6f-80b2-1edd6670be3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a1d1ee-62f8-442a-b9e2-c0631e176b86");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d151de5-8f76-4fb3-ab9d-81e0357bbd55", "87d1ff21-b209-4dc1-9a6b-b7322f6a0b50", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8789aa5-74ae-4b8a-ad93-7a8e4e8fdf5b", "0fbd6067-84c5-4843-a406-e5b0c9fa920a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d151de5-8f76-4fb3-ab9d-81e0357bbd55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8789aa5-74ae-4b8a-ad93-7a8e4e8fdf5b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2098a5ac-d882-4f6f-80b2-1edd6670be3d", "3feb48c4-87f2-4e23-a80c-57a7b7723bfb", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61a1d1ee-62f8-442a-b9e2-c0631e176b86", "d3c8b5c9-4085-4121-9f0a-1ecbffb4c245", "Administrator", "ADMINISTRATOR" });
        }
    }
}
