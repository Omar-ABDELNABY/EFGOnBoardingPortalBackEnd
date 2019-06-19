using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ningthremoveSubhubID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9497f75b-ad24-4c82-84b6-0f9d61652aa8", "6c293b1f-ece7-4800-94f4-ea0dcea3fd92" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20e4b383-ad6e-4aa9-bbe1-464c6a3f66df", 0, false, "15d3d0a8-463e-495e-b519-fd1fed967631", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAENTzk61pgyXsVZ1Og6z6PFDQENMpx072SbDN5wCeeSw+aoxqYB2TZfb3WYiJ7PGkrg==", null, false, "", 0, false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "20e4b383-ad6e-4aa9-bbe1-464c6a3f66df", "15d3d0a8-463e-495e-b519-fd1fed967631" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9497f75b-ad24-4c82-84b6-0f9d61652aa8", 0, false, "6c293b1f-ece7-4800-94f4-ea0dcea3fd92", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEH3XJ9RRIoke4o8tcLt9fWUwUwAN6kZMyNi/+/zhTx50xEE5G4xEKoFmU0XrdiUDlQ==", null, false, "", 0, false, "admin" });
        }
    }
}
