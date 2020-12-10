using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class GradeDataTypeChangedToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "GradesPerTerms",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9784ce37-d927-4bcf-bfad-103eead594a3", "AQAAAAEAACcQAAAAEKeJNVUxzUy6Wck/PZQyYXCHkEm746pBmWbMS/SLexDnv30wu6sN33QqJkKnatFnnA==", "5ae24963-5e79-4798-ae07-a3a558342f2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Grade",
                table: "GradesPerTerms",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4380f6-7915-49fe-b423-6568f97de09b", "AQAAAAEAACcQAAAAELgRkameW+SApp7oQT9lQmgUAU2xHz5rbjhkE0r83l2vqvPWR7tiAV4PWHx3KIrZbg==", "83541e88-5e06-4328-9042-42f9e407d137" });
        }
    }
}
