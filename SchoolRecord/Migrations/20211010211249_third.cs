using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolRecord.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schoolClass_schoolTeacher_teacherid",
                table: "schoolClass");

            migrationBuilder.DropIndex(
                name: "IX_schoolClass_teacherid",
                table: "schoolClass");

            migrationBuilder.DropColumn(
                name: "teacherid",
                table: "schoolClass");

            migrationBuilder.AddColumn<int>(
                name: "schoolTeacherID",
                table: "schoolClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_schoolClass_schoolTeacherID",
                table: "schoolClass",
                column: "schoolTeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_schoolClass_schoolTeacher_schoolTeacherID",
                table: "schoolClass",
                column: "schoolTeacherID",
                principalTable: "schoolTeacher",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schoolClass_schoolTeacher_schoolTeacherID",
                table: "schoolClass");

            migrationBuilder.DropIndex(
                name: "IX_schoolClass_schoolTeacherID",
                table: "schoolClass");

            migrationBuilder.DropColumn(
                name: "schoolTeacherID",
                table: "schoolClass");

            migrationBuilder.AddColumn<int>(
                name: "teacherid",
                table: "schoolClass",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schoolClass_teacherid",
                table: "schoolClass",
                column: "teacherid");

            migrationBuilder.AddForeignKey(
                name: "FK_schoolClass_schoolTeacher_teacherid",
                table: "schoolClass",
                column: "teacherid",
                principalTable: "schoolTeacher",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
