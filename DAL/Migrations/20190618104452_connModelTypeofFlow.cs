using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class connModelTypeofFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2cdf0957-f866-4ee7-a25d-bccf6c244f1b", "43332293-b17e-4371-aafd-ae07d068e297" });

            migrationBuilder.AddColumn<string>(
                name: "TypeOfFlow",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UAT",
                table: "Connections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da48d163-9567-48e2-bfad-499e107b67af", 0, false, "881ad14e-b2ce-49ca-a3bc-2e379fa633ab", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEOX/BFo331grwtNzHbK1Sv+zrx6+ru9KjhFcvzd5Dis2z4EO42GJLXKRVHSgky1RLw==", null, false, "", 0, false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "da48d163-9567-48e2-bfad-499e107b67af", "881ad14e-b2ce-49ca-a3bc-2e379fa633ab" });

            migrationBuilder.DropColumn(
                name: "TypeOfFlow",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "UAT",
                table: "Connections");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2cdf0957-f866-4ee7-a25d-bccf6c244f1b", 0, false, "43332293-b17e-4371-aafd-ae07d068e297", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEJwotDuTh7zsp+lNhAGpqQK1biXpsSPG40owMTv/Iw/bMF2IQARPqXokc93SzDRgDA==", null, false, "", 0, false, "admin" });
        }
    }
}
