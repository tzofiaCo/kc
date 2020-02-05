using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class addRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerTypeId",
                table: "Publishers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_OwnerTypeId",
                table: "Publishers",
                column: "OwnerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_OwnerTypes_OwnerTypeId",
                table: "Publishers",
                column: "OwnerTypeId",
                principalTable: "OwnerTypes",
                principalColumn: "OwnerTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_OwnerTypes_OwnerTypeId",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_OwnerTypeId",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "OwnerTypeId",
                table: "Publishers");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
