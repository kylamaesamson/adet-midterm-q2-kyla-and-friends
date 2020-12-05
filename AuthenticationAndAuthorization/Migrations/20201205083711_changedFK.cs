using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class changedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StudentGrades_StudentGradesID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesForTerm_GradeSheet_GradeSheetID",
                table: "GradesForTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesForTerm_GradesForTermID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentGradesID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeSheet",
                table: "GradeSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradesForTerm",
                table: "GradesForTerm");

            migrationBuilder.DropColumn(
                name: "GradesID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "GradeSheet",
                newName: "GradeSheets");

            migrationBuilder.RenameTable(
                name: "GradesForTerm",
                newName: "GradesForTerms");

            migrationBuilder.RenameIndex(
                name: "IX_GradesForTerm_GradeSheetID",
                table: "GradesForTerms",
                newName: "IX_GradesForTerms_GradeSheetID");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeSheets",
                table: "GradeSheets",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradesForTerms",
                table: "GradesForTerms",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GradesForTerms_GradeSheets_GradeSheetID",
                table: "GradesForTerms",
                column: "GradeSheetID",
                principalTable: "GradeSheets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesForTerms_GradesForTermID",
                table: "StudentGrades",
                column: "GradesForTermID",
                principalTable: "GradesForTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradesForTerms_GradeSheets_GradeSheetID",
                table: "GradesForTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesForTerms_GradesForTermID",
                table: "StudentGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradeSheets",
                table: "GradeSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradesForTerms",
                table: "GradesForTerms");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "StudentGrades");

            migrationBuilder.RenameTable(
                name: "GradeSheets",
                newName: "GradeSheet");

            migrationBuilder.RenameTable(
                name: "GradesForTerms",
                newName: "GradesForTerm");

            migrationBuilder.RenameIndex(
                name: "IX_GradesForTerms_GradeSheetID",
                table: "GradesForTerm",
                newName: "IX_GradesForTerm_GradeSheetID");

            migrationBuilder.AddColumn<int>(
                name: "GradesID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradeSheet",
                table: "GradeSheet",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradesForTerm",
                table: "GradesForTerm",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentGradesID",
                table: "AspNetUsers",
                column: "StudentGradesID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StudentGrades_StudentGradesID",
                table: "AspNetUsers",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesForTerm_GradeSheet_GradeSheetID",
                table: "GradesForTerm",
                column: "GradeSheetID",
                principalTable: "GradeSheet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesForTerm_GradesForTermID",
                table: "StudentGrades",
                column: "GradesForTermID",
                principalTable: "GradesForTerm",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
