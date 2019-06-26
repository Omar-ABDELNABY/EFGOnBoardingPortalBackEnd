using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class userModelFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "SubhubID",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HubID",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ClientID", "ConcurrencyStamp", "HubID", "PasswordHash", "SubhubID" },
                values: new object[] { 0, "20c845a2-5961-42bf-8e8a-9c5b12e7be2e", 0, "AQAAAAEAACcQAAAAENYFduEvCeCps65NVzfJ9l80/NMa/4AAfFUR2Lyauzad7kXZyIdpqjeqdBVynbgCCw==", 0 });

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Bloomberg EMSX");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Bloomberg EMSX NET");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Reuters REDI");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clients_ClientID",
                table: "AspNetUsers",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Hubs_HubID",
                table: "AspNetUsers",
                column: "HubID",
                principalTable: "Hubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubHubs_SubhubID",
                table: "AspNetUsers",
                column: "SubhubID",
                principalTable: "SubHubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<int>(
                name: "SubhubID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HubID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ClientID", "ConcurrencyStamp", "HubID", "PasswordHash", "SubhubID" },
                values: new object[] { null, "921060ad-dde0-45b8-a34c-19fa9c7c0407", null, "AQAAAAEAACcQAAAAEGxG+0Lbb9ZDesErijh/hdrvFnpat5uKPif6OQThKzcBO6LUgLI4+zjKWmuPg0D7lg==", null });

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
                keyValue: 4,
                column: "Name",
                value: "Reuters Normal");

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
    }
}
