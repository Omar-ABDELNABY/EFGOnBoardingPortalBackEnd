using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class twelvthAdminRole1stTrial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e0d47c3c-a970-469b-bf3e-5a66750cc82b", "03a72d96-ef35-4c70-9ad4-d29de7128f6c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1234567890", 0, false, "8e4059d7-28d3-43a4-b792-f33e17becb18", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEBkyfdInespmRpDyxidRRC1S83FhC6NbKEGVuwO8opfM4z+w+YWQoYcLASwM3PQ8TQ==", null, false, "", 0, false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1234567890", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1234567890", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1234567890", "8e4059d7-28d3-43a4-b792-f33e17becb18" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0d47c3c-a970-469b-bf3e-5a66750cc82b", 0, false, "03a72d96-ef35-4c70-9ad4-d29de7128f6c", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEER8Woikpke8Ta8VfmW4b1LMIPOCyLXl7kpES3sQN+mK0/HnL10gHUWVh4EaIOtPqg==", null, false, "", 0, false, "admin" });
        }
    }
}
