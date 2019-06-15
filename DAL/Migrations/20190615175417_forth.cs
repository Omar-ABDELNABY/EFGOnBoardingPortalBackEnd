using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f50496fe-8f6f-4e79-8654-87320839f33c", "b17aae9d-e95c-4d6e-b98c-3bcac448721b" });

            migrationBuilder.AddColumn<bool>(
                name: "Approval",
                table: "Connections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deactivated",
                table: "Connections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2a068d7-889e-4b7e-b668-0a9ecb6c0a3b", 0, false, "09d1618c-328a-445d-8559-e4d2b2549b96", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEEZL7zJzfXX4m35XiNBdRQGfDR5z04qKKeWoLKpR9BLUEbnjCpOLYY/26bFGp2I/Gg==", null, false, "", 0, false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c2a068d7-889e-4b7e-b668-0a9ecb6c0a3b", "09d1618c-328a-445d-8559-e4d2b2549b96" });

            migrationBuilder.DropColumn(
                name: "Approval",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Deactivated",
                table: "Connections");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f50496fe-8f6f-4e79-8654-87320839f33c", 0, false, "b17aae9d-e95c-4d6e-b98c-3bcac448721b", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEHrussju52EURDYEoj5QLtvNHkTgeN3cPxeeME9cLxmCLuY6/JQ1nHIy6G9GB2P7gA==", null, false, "", 0, false, "admin" });
        }
    }
}
