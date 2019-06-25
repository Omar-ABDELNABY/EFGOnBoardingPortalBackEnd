using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updateAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InitiatorType",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HubID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubhubID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "921060ad-dde0-45b8-a34c-19fa9c7c0407", "AQAAAAEAACcQAAAAEGxG+0Lbb9ZDesErijh/hdrvFnpat5uKPif6OQThKzcBO6LUgLI4+zjKWmuPg0D7lg==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClientID",
                table: "AspNetUsers",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HubID",
                table: "AspNetUsers",
                column: "HubID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubhubID",
                table: "AspNetUsers",
                column: "SubhubID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clients_ClientID",
                table: "AspNetUsers",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Hubs_HubID",
                table: "AspNetUsers",
                column: "HubID",
                principalTable: "Hubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubHubs_SubhubID",
                table: "AspNetUsers",
                column: "SubhubID",
                principalTable: "SubHubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Clients_ClientID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Hubs_HubID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubHubs_SubhubID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClientID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HubID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubhubID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HubID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SubhubID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "InitiatorType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa50fea8-45f9-4e1b-933d-c1cc648bc375", "AQAAAAEAACcQAAAAEN2Ry+ge7oiaUZ7hLCnIc59QsZPLw3g7hFZfLI5L7iqdsWwVdFrLX1sBMDeXgRBOsg==" });
        }
    }
}
