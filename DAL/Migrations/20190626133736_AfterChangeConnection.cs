using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AfterChangeConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfFlow",
                table: "Connections");

            migrationBuilder.AddColumn<bool>(
                name: "CARE",
                table: "Connections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DMA",
                table: "Connections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5329f73e-0049-4a60-8444-c78ef6f5b5af", "AQAAAAEAACcQAAAAEFFLseQNjQDwXg4s1onKPWh7CYI/0RptINjesB1WTmGVBF5jhhw+Osllf5gvzP8bSw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CARE",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "DMA",
                table: "Connections");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfFlow",
                table: "Connections",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9210e239-b17d-414f-ad12-3beefc270d38", "AQAAAAEAACcQAAAAEAB2R8JuweXzSZkAh54cnBMn8hInSI5eRvLyi+0s+17p10YHkehafKoGMVtwv3mTMg==" });
        }
    }
}
