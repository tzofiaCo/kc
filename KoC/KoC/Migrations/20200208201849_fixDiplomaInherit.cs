using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class fixDiplomaInherit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Diplomas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Context",
                table: "Diplomas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Diplomas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Diplomas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Diplomas");

            migrationBuilder.DropColumn(
                name: "Context",
                table: "Diplomas");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Diplomas");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Diplomas");
        }
    }
}
