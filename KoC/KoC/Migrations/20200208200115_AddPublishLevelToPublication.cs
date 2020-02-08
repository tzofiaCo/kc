using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class AddPublishLevelToPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "publishLevel",
                table: "Publications",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publishLevel",
                table: "Publications");
        }
    }
}
