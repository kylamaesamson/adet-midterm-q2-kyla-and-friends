using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class seedinadmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Finals");

            migrationBuilder.DropTable(
                name: "Midterms");

            migrationBuilder.DropTable(
                name: "Prefnals");

            migrationBuilder.DropTable(
                name: "Prelims");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FinalGrade",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MidtermGrade",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrefinalGrade",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrelimGrade",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Final",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Midterm",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Prefinal",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Prelim",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "HomeAddress", "LastName", "Role" },
                values: new object[] { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, "396456ad-da27-4e3b-bc50-e796491f785c", "AppUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL>COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEEDov3FdM1/tCz6K5KARHABnR2TsfM/jrzn41H+1ySlwoa7l095Q7Om6fg3RBHAH/w==", null, false, "3971f640-7939-4116-8349-721edeee9e38", false, "administrator", "admin", null, "admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.DropColumn(
                name: "Assignment1Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment1Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment1Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment1Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment2Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment2Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment2Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment2Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment3Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment3Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment3Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment3Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "FinalGrade",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "MidtermGrade",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "PrefinalGrade",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "PrelimGrade",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz1Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz1Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz1Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz1Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz2Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz2Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz2Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz2Prelim",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz3Final",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz3Midterm",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz3Prefinal",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Quiz3Prelim",
                table: "StudentGrades");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGrade = table.Column<float>(type: "real", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    TotalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Finals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(type: "int", nullable: false),
                    ass1ID = table.Column<int>(type: "int", nullable: true),
                    ass2ID = table.Column<int>(type: "int", nullable: true),
                    ass3ID = table.Column<int>(type: "int", nullable: true),
                    quiz1ID = table.Column<int>(type: "int", nullable: true),
                    quiz2ID = table.Column<int>(type: "int", nullable: true),
                    quiz3ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Midterms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(type: "int", nullable: false),
                    ass1ID = table.Column<int>(type: "int", nullable: true),
                    ass2ID = table.Column<int>(type: "int", nullable: true),
                    ass3ID = table.Column<int>(type: "int", nullable: true),
                    quiz1ID = table.Column<int>(type: "int", nullable: true),
                    quiz2ID = table.Column<int>(type: "int", nullable: true),
                    quiz3ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midterms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prefnals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(type: "int", nullable: false),
                    ass1ID = table.Column<int>(type: "int", nullable: true),
                    ass2ID = table.Column<int>(type: "int", nullable: true),
                    ass3ID = table.Column<int>(type: "int", nullable: true),
                    quiz1ID = table.Column<int>(type: "int", nullable: true),
                    quiz2ID = table.Column<int>(type: "int", nullable: true),
                    quiz3ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefnals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prelims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesID = table.Column<int>(type: "int", nullable: false),
                    ass1ID = table.Column<int>(type: "int", nullable: true),
                    ass2ID = table.Column<int>(type: "int", nullable: true),
                    ass3ID = table.Column<int>(type: "int", nullable: true),
                    quiz1ID = table.Column<int>(type: "int", nullable: true),
                    quiz2ID = table.Column<int>(type: "int", nullable: true),
                    quiz3ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prelims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGrade = table.Column<float>(type: "real", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    TotalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.ID);
                });
        }
    }
}
