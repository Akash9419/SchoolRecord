using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolRecord.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schoolAdminssion_schoolClass_school_Classid",
                table: "schoolAdminssion");

            migrationBuilder.DropIndex(
                name: "IX_schoolAdminssion_school_Classid",
                table: "schoolAdminssion");

            migrationBuilder.DropColumn(
                name: "sClass",
                table: "schoolAdminssion");

            migrationBuilder.DropColumn(
                name: "school_Classid",
                table: "schoolAdminssion");

            migrationBuilder.AddColumn<int>(
                name: "SchoolClassID",
                table: "schoolAdminssion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_schoolAdminssion_SchoolClassID",
                table: "schoolAdminssion",
                column: "SchoolClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_schoolAdminssion_schoolClass_SchoolClassID",
                table: "schoolAdminssion",
                column: "SchoolClassID",
                principalTable: "schoolClass",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schoolAdminssion_schoolClass_SchoolClassID",
                table: "schoolAdminssion");

            migrationBuilder.DropIndex(
                name: "IX_schoolAdminssion_SchoolClassID",
                table: "schoolAdminssion");

            migrationBuilder.DropColumn(
                name: "SchoolClassID",
                table: "schoolAdminssion");

            migrationBuilder.AddColumn<string>(
                name: "sClass",
                table: "schoolAdminssion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "school_Classid",
                table: "schoolAdminssion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schoolAdminssion_school_Classid",
                table: "schoolAdminssion",
                column: "school_Classid");

            migrationBuilder.AddForeignKey(
                name: "FK_schoolAdminssion_schoolClass_school_Classid",
                table: "schoolAdminssion",
                column: "school_Classid",
                principalTable: "schoolClass",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
