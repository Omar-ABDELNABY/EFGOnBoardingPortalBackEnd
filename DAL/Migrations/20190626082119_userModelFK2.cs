using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class userModelFK2 : Migration
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
                values: new object[] { null, "ec5641c9-660b-449f-be52-7c86675b9fa9", null, "AQAAAAEAACcQAAAAEBXtcEmZB42gzZqwer0T/Sk8n6PSkv3lzNtZ9MhGHSE5w7Nh4/zp/rQTBLu05a6Z3Q==", null });

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
    }
}
