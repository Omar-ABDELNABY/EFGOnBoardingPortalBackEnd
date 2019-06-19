using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class eigth_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Clients_ConnClientClientID",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Hubs_ConnHubHubID",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_SubHubs_ConnSubHubSubhubID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_ConnClientClientID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_ConnHubHubID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_ConnSubHubSubhubID",
                table: "Connections");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6e598058-dd0d-44b3-8351-38e813738f3c", "5708789c-b316-4218-96c5-61d4a6fab336" });

            migrationBuilder.DropColumn(
                name: "ConnClientClientID",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "ConnHubHubID",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "ConnSubHubSubhubID",
                table: "Connections");

            migrationBuilder.RenameColumn(
                name: "SubhubName",
                table: "SubHubs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SubhubID",
                table: "SubHubs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "HubName",
                table: "Hubs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "HubID",
                table: "Hubs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Clients",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Connections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HubID",
                table: "Connections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubHubID",
                table: "Connections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9497f75b-ad24-4c82-84b6-0f9d61652aa8", 0, false, "6c293b1f-ece7-4800-94f4-ea0dcea3fd92", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEH3XJ9RRIoke4o8tcLt9fWUwUwAN6kZMyNi/+/zhTx50xEE5G4xEKoFmU0XrdiUDlQ==", null, false, "", 0, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Connections_ClientID",
                table: "Connections",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_HubID",
                table: "Connections",
                column: "HubID");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_SubHubID",
                table: "Connections",
                column: "SubHubID");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Clients_ClientID",
                table: "Connections",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Hubs_HubID",
                table: "Connections",
                column: "HubID",
                principalTable: "Hubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections",
                column: "SubHubID",
                principalTable: "SubHubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Clients_ClientID",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Hubs_HubID",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_SubHubs_SubHubID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_ClientID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_HubID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_SubHubID",
                table: "Connections");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9497f75b-ad24-4c82-84b6-0f9d61652aa8", "6c293b1f-ece7-4800-94f4-ea0dcea3fd92" });

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "HubID",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "SubHubID",
                table: "Connections");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SubHubs",
                newName: "SubhubName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SubHubs",
                newName: "SubhubID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hubs",
                newName: "HubName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Hubs",
                newName: "HubID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "ClientName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clients",
                newName: "ClientID");

            migrationBuilder.AddColumn<int>(
                name: "ConnClientClientID",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConnHubHubID",
                table: "Connections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConnSubHubSubhubID",
                table: "Connections",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Approval", "ConcurrencyStamp", "Deactivated", "Email", "EmailConfirmed", "Firstname", "ITContact", "InitiatorType", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TraderContact", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e598058-dd0d-44b3-8351-38e813738f3c", 0, false, "5708789c-b316-4218-96c5-61d4a6fab336", false, "admin@efg.com", true, null, 0, 0, null, false, null, "ADMIN@EFG.COM", "ADMIN", "AQAAAAEAACcQAAAAEFTz4P2fZ8g4JTygEeWYw9Jg69ZF3KvscTLz3iWjEGNZVbQ8AMERN39p6WLjl87LMQ==", null, false, "", 0, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 1,
                column: "HubName",
                value: "Bloomberg ESMX");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 2,
                column: "HubName",
                value: "Bloomberg ESMX NET");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 3,
                column: "HubName",
                value: "Reuters Autex");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 4,
                column: "HubName",
                value: "Reuters Normal");

            migrationBuilder.UpdateData(
                table: "Hubs",
                keyColumn: "HubID",
                keyValue: 5,
                column: "HubName",
                value: "Fidessa");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_ConnClientClientID",
                table: "Connections",
                column: "ConnClientClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_ConnHubHubID",
                table: "Connections",
                column: "ConnHubHubID");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_ConnSubHubSubhubID",
                table: "Connections",
                column: "ConnSubHubSubhubID");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Clients_ConnClientClientID",
                table: "Connections",
                column: "ConnClientClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Hubs_ConnHubHubID",
                table: "Connections",
                column: "ConnHubHubID",
                principalTable: "Hubs",
                principalColumn: "HubID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_SubHubs_ConnSubHubSubhubID",
                table: "Connections",
                column: "ConnSubHubSubhubID",
                principalTable: "SubHubs",
                principalColumn: "SubhubID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
