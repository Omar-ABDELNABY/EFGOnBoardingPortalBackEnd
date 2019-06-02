using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InitiatorType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f50496fe-8f6f-4e79-8654-87320839f33c", 0, false, "b17aae9d-e95c-4d6e-b98c-3bcac448721b", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEHrussju52EURDYEoj5QLtvNHkTgeN3cPxeeME9cLxmCLuY6/JQ1nHIy6G9GB2P7gA==", null, false, "", 0, false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f50496fe-8f6f-4e79-8654-87320839f33c", "b17aae9d-e95c-4d6e-b98c-3bcac448721b" });

            migrationBuilder.DropColumn(
                name: "InitiatorType",
                table: "AspNetUsers");
        }
    }
}
