using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class finishinGrad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SubjectGrade",
                table: "StudentGrades",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851a4259-2ad9-402a-9cf8-d634702e9bcf", "AQAAAAEAACcQAAAAEPig4xBqVF9pnRCz5O5DdmSThwQMq/w3ksuy3wC3I4bUQcyL03CY/h3/ACYP1uUhgQ==", "89916dd5-ba3e-48d9-9927-51edc85352ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectGrade",
                table: "StudentGrades");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9784ce37-d927-4bcf-bfad-103eead594a3", "AQAAAAEAACcQAAAAEKeJNVUxzUy6Wck/PZQyYXCHkEm746pBmWbMS/SLexDnv30wu6sN33QqJkKnatFnnA==", "5ae24963-5e79-4798-ae07-a3a558342f2c" });
        }
    }
}
