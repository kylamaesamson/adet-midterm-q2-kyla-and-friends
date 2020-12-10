using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class studentgades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "GradesID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GradesPerTerms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<string>(nullable: true),
                    Quiz1ID = table.Column<int>(nullable: true),
                    Quiz1Grade = table.Column<float>(nullable: false),
                    Quiz2ID = table.Column<int>(nullable: true),
                    Quiz2Grade = table.Column<float>(nullable: false),
                    Quiz3ID = table.Column<int>(nullable: true),
                    Quiz3Grade = table.Column<float>(nullable: false),
                    Ass1ID = table.Column<int>(nullable: true),
                    Ass1Grade = table.Column<float>(nullable: false),
                    Ass2ID = table.Column<int>(nullable: true),
                    Ass2Grade = table.Column<float>(nullable: false),
                    Ass3ID = table.Column<int>(nullable: true),
                    Ass3Grade = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradesPerTerms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemScores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    TotalItems = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Grade = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemScores", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe493014-1482-47b6-8d60-dcb3fea94863", "AQAAAAEAACcQAAAAELJ02QjnhWZFFMAaGl+1GiTUbQBkNypzwqcxIAv4OusBHyiZQGg8PYJYPFYigA0GHg==", "f7a734f2-bd20-4760-8452-687891dbfc37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradesPerTerms");

            migrationBuilder.DropTable(
                name: "ItemScores");

            migrationBuilder.DropColumn(
                name: "GradesID",
                table: "StudentGrades");

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz1Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz2Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Final",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Midterm",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Prefinal",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quiz3Prelim",
                table: "StudentGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396456ad-da27-4e3b-bc50-e796491f785c", "AQAAAAEAACcQAAAAEEDov3FdM1/tCz6K5KARHABnR2TsfM/jrzn41H+1ySlwoa7l095Q7Om6fg3RBHAH/w==", "3971f640-7939-4116-8349-721edeee9e38" });
        }
    }
}
