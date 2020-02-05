using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class addActivToDetailsCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CourseDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "CourseDetails");
        }
    }
}
