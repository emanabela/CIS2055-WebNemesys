using Microsoft.EntityFrameworkCore.Migrations;

namespace Nemesys.Migrations
{
    public partial class ioejdnoasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheRole",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "TheRole",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
