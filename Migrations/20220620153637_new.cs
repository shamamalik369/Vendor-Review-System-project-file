using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor_Review_System.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_venmols",
                table: "venmols");

            migrationBuilder.RenameTable(
                name: "venmols",
                newName: "Venmols");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venmols",
                table: "Venmols",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Venmols",
                table: "Venmols");

            migrationBuilder.RenameTable(
                name: "Venmols",
                newName: "venmols");

            migrationBuilder.AddPrimaryKey(
                name: "PK_venmols",
                table: "venmols",
                column: "ID");
        }
    }
}
