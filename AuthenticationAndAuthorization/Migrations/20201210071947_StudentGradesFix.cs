using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class StudentGradesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserId",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "StudentGrades");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "StudentGrades",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGrades_AppUserId",
                table: "StudentGrades",
                newName: "IX_StudentGrades_AppUserID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4380f6-7915-49fe-b423-6568f97de09b", "AQAAAAEAACcQAAAAELgRkameW+SApp7oQT9lQmgUAU2xHz5rbjhkE0r83l2vqvPWR7tiAV4PWHx3KIrZbg==", "83541e88-5e06-4328-9042-42f9e407d137" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserID",
                table: "StudentGrades",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserID",
                table: "StudentGrades");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "StudentGrades",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGrades_AppUserID",
                table: "StudentGrades",
                newName: "IX_StudentGrades_AppUserId");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "StudentGrades",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d6e950-7764-4852-b517-422544f8dea0", "AQAAAAEAACcQAAAAEGlnModKQUMiVd1xzW/+IpTCz5+iMDEwipQZUirR4K7ASEBjRBkIaJ1xQd9b6rwzYA==", "56836108-0db7-432a-9b9a-711a8ea66411" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserId",
                table: "StudentGrades",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
