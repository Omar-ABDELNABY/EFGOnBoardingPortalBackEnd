using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class eleventhHubNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b13e7871-2ebf-4e96-a1fc-8d79de06186b", "da2580ea-5abd-4e89-b2bb-9092625f0b95" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0d47c3c-a970-469b-bf3e-5a66750cc82b", 0, false, "03a72d96-ef35-4c70-9ad4-d29de7128f6c", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEER8Woikpke8Ta8VfmW4b1LMIPOCyLXl7kpES3sQN+mK0/HnL10gHUWVh4EaIOtPqg==", null, false, "", 0, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Bloomberg ESMX");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Bloomberg ESMX NET");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Reuters Autex");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Reuters Normal");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Fidessa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e0d47c3c-a970-469b-bf3e-5a66750cc82b", "03a72d96-ef35-4c70-9ad4-d29de7128f6c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b13e7871-2ebf-4e96-a1fc-8d79de06186b", 0, false, "da2580ea-5abd-4e89-b2bb-9092625f0b95", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAENg8CP/Cl4KS2nuRmt2GTqgDJrYmkl+HZ1AuVMk3hpu0IXkqK3dJz5x+25Bz6Xr2pA==", null, false, "", 0, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: null);
        }
    }
}
