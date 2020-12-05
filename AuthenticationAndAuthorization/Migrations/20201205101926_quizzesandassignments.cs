using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class quizzesandassignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Finals_StudentGrades_StudentGradesID",
                table: "Finals");

            migrationBuilder.DropForeignKey(
                name: "FK_Midterms_StudentGrades_StudentGradesID",
                table: "Midterms");

            migrationBuilder.DropForeignKey(
                name: "FK_Prefnals_StudentGrades_StudentGradesID",
                table: "Prefnals");

            migrationBuilder.DropForeignKey(
                name: "FK_Prelims_StudentGrades_StudentGradesID",
                table: "Prelims");

            migrationBuilder.DropIndex(
                name: "IX_Prelims_StudentGradesID",
                table: "Prelims");

            migrationBuilder.DropIndex(
                name: "IX_Prefnals_StudentGradesID",
                table: "Prefnals");

            migrationBuilder.DropIndex(
                name: "IX_Midterms_StudentGradesID",
                table: "Midterms");

            migrationBuilder.DropIndex(
                name: "IX_Finals_StudentGradesID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "Finals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "Prelims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "Prefnals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "Midterms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "Finals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prelims_StudentGradesID",
                table: "Prelims",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Prefnals_StudentGradesID",
                table: "Prefnals",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Midterms_StudentGradesID",
                table: "Midterms",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Finals_StudentGradesID",
                table: "Finals",
                column: "StudentGradesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Finals_StudentGrades_StudentGradesID",
                table: "Finals",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Midterms_StudentGrades_StudentGradesID",
                table: "Midterms",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prefnals_StudentGrades_StudentGradesID",
                table: "Prefnals",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prelims_StudentGrades_StudentGradesID",
                table: "Prelims",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
