using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    From = table.Column<string>(nullable: false),
                    FromPassword = table.Column<string>(nullable: false),
                    To = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa50fea8-45f9-4e1b-933d-c1cc648bc375", "AQAAAAEAACcQAAAAEN2Ry+ge7oiaUZ7hLCnIc59QsZPLw3g7hFZfLI5L7iqdsWwVdFrLX1sBMDeXgRBOsg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e4059d7-28d3-43a4-b792-f33e17becb18", "AQAAAAEAACcQAAAAEBkyfdInespmRpDyxidRRC1S83FhC6NbKEGVuwO8opfM4z+w+YWQoYcLASwM3PQ8TQ==" });
        }
    }
}
