using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class gradesView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "StudentGrades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Assignment1ID",
                table: "GradesPerTerms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Assignment2ID",
                table: "GradesPerTerms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Assignment3ID",
                table: "GradesPerTerms",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a486a394-e315-4d90-a127-96c2755382e7", "AQAAAAEAACcQAAAAEAO/iw/B5xjFKlYvg+sarjWrNdmQ+mzuFjVkyWIDQmY7mTwO1tHqFqPKPm/ABCiPYw==", "094a9cd7-037a-4a00-9957-6997cd09fc36" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_AppUserId",
                table: "StudentGrades",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_FinalID",
                table: "StudentGrades",
                column: "FinalID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_MidtermID",
                table: "StudentGrades",
                column: "MidtermID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_PrefinalID",
                table: "StudentGrades",
                column: "PrefinalID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_PrelimID",
                table: "StudentGrades",
                column: "PrelimID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Assignment1ID",
                table: "GradesPerTerms",
                column: "Assignment1ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Assignment2ID",
                table: "GradesPerTerms",
                column: "Assignment2ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Assignment3ID",
                table: "GradesPerTerms",
                column: "Assignment3ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Quiz1ID",
                table: "GradesPerTerms",
                column: "Quiz1ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Quiz2ID",
                table: "GradesPerTerms",
                column: "Quiz2ID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesPerTerms_Quiz3ID",
                table: "GradesPerTerms",
                column: "Quiz3ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment1ID",
                table: "GradesPerTerms",
                column: "Assignment1ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment2ID",
                table: "GradesPerTerms",
                column: "Assignment2ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment3ID",
                table: "GradesPerTerms",
                column: "Assignment3ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz1ID",
                table: "GradesPerTerms",
                column: "Quiz1ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz2ID",
                table: "GradesPerTerms",
                column: "Quiz2ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz3ID",
                table: "GradesPerTerms",
                column: "Quiz3ID",
                principalTable: "ItemScores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserId",
                table: "StudentGrades",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_FinalID",
                table: "StudentGrades",
                column: "FinalID",
                principalTable: "GradesPerTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_MidtermID",
                table: "StudentGrades",
                column: "MidtermID",
                principalTable: "GradesPerTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_PrefinalID",
                table: "StudentGrades",
                column: "PrefinalID",
                principalTable: "GradesPerTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_PrelimID",
                table: "StudentGrades",
                column: "PrelimID",
                principalTable: "GradesPerTerms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Assignment3ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_GradesPerTerms_ItemScores_Quiz3ID",
                table: "GradesPerTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_AspNetUsers_AppUserId",
                table: "StudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_FinalID",
                table: "StudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_MidtermID",
                table: "StudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_PrefinalID",
                table: "StudentGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGrades_GradesPerTerms_PrelimID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_AppUserId",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_FinalID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_MidtermID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_PrefinalID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_StudentGrades_PrelimID",
                table: "StudentGrades");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Assignment1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Assignment2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Assignment3ID",
                table: "GradesPerTerms");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Quiz1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Quiz2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropIndex(
                name: "IX_GradesPerTerms_Quiz3ID",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "StudentGrades");

            migrationBuilder.DropColumn(
                name: "Assignment1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Assignment2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Assignment3ID",
                table: "GradesPerTerms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "737b15d4-2bc8-4f06-acf4-c5adb788f44b", "AQAAAAEAACcQAAAAEH6d3pzawreyNDAhAd27xfB6VXfIdIYLfcUCl+BjmUDGchojGYgPLQjje2gERNkUXw==", "f10f8887-6b1e-4e6e-b70d-3cddda8d2eb8" });
        }
    }
}
