using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor_Review_System.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_venmils",
                table: "venmils");

            migrationBuilder.RenameTable(
                name: "venmils",
                newName: "venmols");

            migrationBuilder.RenameColumn(
                name: "WensiteID",
                table: "venmols",
                newName: "WebsiteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_venmols",
                table: "venmols",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_venmols",
                table: "venmols");

            migrationBuilder.RenameTable(
                name: "venmols",
                newName: "venmils");

            migrationBuilder.RenameColumn(
                name: "WebsiteID",
                table: "venmils",
                newName: "WensiteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_venmils",
                table: "venmils",
                column: "ID");
        }
    }
}
