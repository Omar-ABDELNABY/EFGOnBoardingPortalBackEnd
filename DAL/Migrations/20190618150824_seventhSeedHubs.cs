using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seventhSeedHubs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "da48d163-9567-48e2-bfad-499e107b67af", "881ad14e-b2ce-49ca-a3bc-2e379fa633ab" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e598058-dd0d-44b3-8351-38e813738f3c", 0, false, "5708789c-b316-4218-96c5-61d4a6fab336", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEFTz4P2fZ8g4JTygEeWYw9Jg69ZF3KvscTLz3iWjEGNZVbQ8AMERN39p6WLjl87LMQ==", null, false, "", 0, false, "admin" });

            migrationBuilder.InsertData(
                table: "Hubs",
                columns: new[] { "HubID", "HubName" },
                values: new object[,]
                {
                    { 1, "Bloomberg ESMX" },
                    { 2, "Bloomberg ESMX NET" },
                    { 3, "Reuters Autex" },
                    { 4, "Reuters Normal" },
                    { 5, "Fidessa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6e598058-dd0d-44b3-8351-38e813738f3c", "5708789c-b316-4218-96c5-61d4a6fab336" });

            migrationBuilder.DeleteData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da48d163-9567-48e2-bfad-499e107b67af", 0, false, "881ad14e-b2ce-49ca-a3bc-2e379fa633ab", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEOX/BFo331grwtNzHbK1Sv+zrx6+ru9KjhFcvzd5Dis2z4EO42GJLXKRVHSgky1RLw==", null, false, "", 0, false, "admin" });
        }
    }
}
