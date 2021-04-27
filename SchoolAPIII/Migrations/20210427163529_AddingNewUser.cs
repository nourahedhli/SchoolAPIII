using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPIII.Migrations
{
    public partial class AddingNewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "OrganizationId", "UserName" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "nouraHedhli" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"));
        }
    }
}
