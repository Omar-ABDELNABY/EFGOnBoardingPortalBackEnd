using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class userModelFK3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b5c080f-345a-4317-849e-e4b66fcc6956", "AQAAAAEAACcQAAAAEGPR3WK/ZhdniOnkaF8RUmS+5CEnR+G8qAwTtFXh3TT8s6veXXVPhOiFDJl2bSSkHw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec5641c9-660b-449f-be52-7c86675b9fa9", "AQAAAAEAACcQAAAAEBXtcEmZB42gzZqwer0T/Sk8n6PSkv3lzNtZ9MhGHSE5w7Nh4/zp/rQTBLu05a6Z3Q==" });
        }
    }
}
