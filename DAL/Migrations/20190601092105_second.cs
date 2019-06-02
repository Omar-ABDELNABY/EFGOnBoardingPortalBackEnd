using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubhubName",
                table: "SubHubs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HubName",
                table: "Hubs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Clients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubhubName",
                table: "SubHubs");

            migrationBuilder.DropColumn(
                name: "HubName",
                table: "Hubs");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Clients");
        }
    }
}
