using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor_Review_System.Migrations
{
    public partial class restart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "VendorModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "VendorModels");
        }
    }
}
