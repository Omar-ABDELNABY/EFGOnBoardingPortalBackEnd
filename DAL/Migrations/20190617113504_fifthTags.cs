using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class fifthTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c2a068d7-889e-4b7e-b668-0a9ecb6c0a3b", "09d1618c-328a-445d-8559-e4d2b2549b96" });

            migrationBuilder.AddColumn<string>(
                name: "OMS",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag1",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag100",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag115",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag207",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag21",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag30",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag48",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag55",
                table: "Connections",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2cdf0957-f866-4ee7-a25d-bccf6c244f1b", 0, false, "43332293-b17e-4371-aafd-ae07d068e297", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEJwotDuTh7zsp+lNhAGpqQK1biXpsSPG40owMTv/Iw/bMF2IQARPqXokc93SzDRgDA==", null, false, "", 0, false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2cdf0957-f866-4ee7-a25d-bccf6c244f1b", "43332293-b17e-4371-aafd-ae07d068e297" });

            migrationBuilder.DropColumn(
                name: "OMS",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag1",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag100",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag115",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag207",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag21",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag30",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag48",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Tag55",
                table: "Connections");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2a068d7-889e-4b7e-b668-0a9ecb6c0a3b", 0, false, "09d1618c-328a-445d-8559-e4d2b2549b96", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEEZL7zJzfXX4m35XiNBdRQGfDR5z04qKKeWoLKpR9BLUEbnjCpOLYY/26bFGp2I/Gg==", null, false, "", 0, false, "admin" });
        }
    }
}
