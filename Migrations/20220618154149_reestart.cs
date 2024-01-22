using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor_Review_System.Migrations
{
    public partial class reestart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "VendorModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "VendorModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
