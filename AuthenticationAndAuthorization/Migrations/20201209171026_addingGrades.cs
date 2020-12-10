using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class addingGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalGrade",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "GradesID",
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
                name: "Ass1Grade",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Ass2Grade",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Ass3Grade",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Quiz1Grade",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Quiz2Grade",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Quiz3Grade",
                table: "GradesPerTerms");

            migrationBuilder.AddColumn<int>(
                name: "FinalID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MidtermID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrefinalID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrelimID",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Grade",
                table: "GradesPerTerms",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad3430d8-80bb-4e33-9ad3-7157d625d3ab", "AQAAAAEAACcQAAAAEIwbyYZdRtL5iWevNfbSJ8s7+YynoS2LKNV0njcrisWmhaLSY+M/Be5+YqrKkCls1g==", "5baed936-55db-43e9-a260-607987648dad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "MidtermID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "PrefinalID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "PrelimID",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "GradesPerTerms");

            migrationBuilder.AddColumn<float>(
                name: "FinalGrade",
                table: "StudentGrades",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "GradesID",
                table: "StudentGrades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MidtermGrade",
                table: "StudentGrades",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrefinalGrade",
                table: "StudentGrades",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrelimGrade",
                table: "StudentGrades",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ass1Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ass2Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ass3Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Quiz1Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Quiz2Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Quiz3Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe493014-1482-47b6-8d60-dcb3fea94863", "AQAAAAEAACcQAAAAELJ02QjnhWZFFMAaGl+1GiTUbQBkNypzwqcxIAv4OusBHyiZQGg8PYJYPFYigA0GHg==", "f7a734f2-bd20-4760-8452-687891dbfc37" });
        }
    }
}
