using Microsoft.EntityFrameworkCore.Migrations;

namespace KoC.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetails_Courses_CourseID",
                table: "CourseDetails");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseDetails",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDetails_CourseID",
                table: "CourseDetails",
                newName: "IX_CourseDetails_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetails_Courses_CourseId",
                table: "CourseDetails",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetails_Courses_CourseId",
                table: "CourseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseDetails",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDetails_CourseId",
                table: "CourseDetails",
                newName: "IX_CourseDetails_CourseID");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "CourseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetails_Courses_CourseID",
                table: "CourseDetails",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
