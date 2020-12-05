using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class addedModelsForGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesForTerms_GradesForTermID",
                table: "StudentGrades");

            migrationBuilder.DropTable(
                name: "GradesForTerms");

            migrationBuilder.DropTable(
                name: "GradeSheets");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_GradesForTermID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Finals",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "GradesForTermID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "PreFinals",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "TotalGrade",
                table: "StudentGrades");

            migrationBuilder.CreateTable(
                name: "Finals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(nullable: false),
                    StudentGradesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Finals_StudentGrades_StudentGradesID",
                        column: x => x.StudentGradesID,
                        principalTable: "StudentGrades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Midterms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(nullable: false),
                    StudentGradesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midterms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Midterms_StudentGrades_StudentGradesID",
                        column: x => x.StudentGradesID,
                        principalTable: "StudentGrades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prefnals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(nullable: false),
                    StudentGradesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefnals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prefnals_StudentGrades_StudentGradesID",
                        column: x => x.StudentGradesID,
                        principalTable: "StudentGrades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prelims",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(nullable: false),
                    StudentGradesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prelims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prelims_StudentGrades_StudentGradesID",
                        column: x => x.StudentGradesID,
                        principalTable: "StudentGrades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finals_StudentGradesID",
                table: "Finals",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Midterms_StudentGradesID",
                table: "Midterms",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Prefnals_StudentGradesID",
                table: "Prefnals",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_Prelims_StudentGradesID",
                table: "Prelims",
                column: "StudentGradesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Finals");

            migrationBuilder.DropTable(
                name: "Midterms");

            migrationBuilder.DropTable(
                name: "Prefnals");

            migrationBuilder.DropTable(
                name: "Prelims");

            migrationBuilder.AddColumn<int>(
                name: "Finals",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradesForTermID",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreFinals",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalGrade",
                table: "StudentGrades",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "GradeSheets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGrade = table.Column<float>(type: "real", nullable: false),
                    ItemScore = table.Column<int>(type: "int", nullable: false),
                    ItemTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeSheets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GradesForTerms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeSheetID = table.Column<int>(type: "int", nullable: true),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    assignment1 = table.Column<int>(type: "int", nullable: true),
                    assignment2 = table.Column<int>(type: "int", nullable: true),
                    assignment3 = table.Column<int>(type: "int", nullable: true),
                    quiz1 = table.Column<int>(type: "int", nullable: true),
                    quiz2 = table.Column<int>(type: "int", nullable: true),
                    quiz3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradesForTerms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GradesForTerms_GradeSheets_GradeSheetID",
                        column: x => x.GradeSheetID,
                        principalTable: "GradeSheets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_GradesForTermID",
                table: "StudentGrades",
                column: "GradesForTermID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesForTerms_GradeSheetID",
                table: "GradesForTerms",
                column: "GradeSheetID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesForTerms_GradesForTermID",
                table: "StudentGrades",
                column: "GradesForTermID",
                principalTable: "GradesForTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
