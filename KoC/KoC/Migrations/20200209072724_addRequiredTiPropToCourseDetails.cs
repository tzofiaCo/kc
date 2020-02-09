using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class addRequiredTiPropToCourseDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publishLevel",
                table: "Publications",
                newName: "PublishLevel");

            migrationBuilder.AlterColumn<string>(
                name: "CourseFrequency",
                table: "CourseDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishLevel",
                table: "Publications",
                newName: "publishLevel");

            migrationBuilder.AlterColumn<string>(
                name: "CourseFrequency",
                table: "CourseDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
