using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class tengthFixingCors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "20e4b383-ad6e-4aa9-bbe1-464c6a3f66df", "15d3d0a8-463e-495e-b519-fd1fed967631" });

            migrationBuilder.AlterColumn<int>(
                name: "SubHubID",
                table: "Connections",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b13e7871-2ebf-4e96-a1fc-8d79de06186b", 0, false, "da2580ea-5abd-4e89-b2bb-9092625f0b95", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAENg8CP/Cl4KS2nuRmt2GTqgDJrYmkl+HZ1AuVMk3hpu0IXkqK3dJz5x+25Bz6Xr2pA==", null, false, "", 0, false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections",
                column: "SubHubID",
                principalTable: "SubHubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b13e7871-2ebf-4e96-a1fc-8d79de06186b", "da2580ea-5abd-4e89-b2bb-9092625f0b95" });

            migrationBuilder.AlterColumn<int>(
                name: "SubHubID",
                table: "Connections",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20e4b383-ad6e-4aa9-bbe1-464c6a3f66df", 0, false, "15d3d0a8-463e-495e-b519-fd1fed967631", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAENTzk61pgyXsVZ1Og6z6PFDQENMpx072SbDN5wCeeSw+aoxqYB2TZfb3WYiJ7PGkrg==", null, false, "", 0, false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections",
                column: "SubHubID",
                principalTable: "SubHubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
