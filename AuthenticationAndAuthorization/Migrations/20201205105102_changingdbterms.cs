using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class changingdbterms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ass1ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass2ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass3ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz1ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz2ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz3ID",
                table: "Prelims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass1ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass2ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass3ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz1ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz2ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz3ID",
                table: "Prefnals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass1ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass2ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass3ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz1ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz2ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz3ID",
                table: "Midterms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass1ID",
                table: "Finals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass2ID",
                table: "Finals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ass3ID",
                table: "Finals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz1ID",
                table: "Finals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz2ID",
                table: "Finals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quiz3ID",
                table: "Finals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ass1ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "ass2ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "ass3ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "quiz1ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "quiz2ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "quiz3ID",
                table: "Prelims");

            migrationBuilder.DropColumn(
                name: "ass1ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "ass2ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "ass3ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "quiz1ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "quiz2ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "quiz3ID",
                table: "Prefnals");

            migrationBuilder.DropColumn(
                name: "ass1ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "ass2ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "ass3ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "quiz1ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "quiz2ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "quiz3ID",
                table: "Midterms");

            migrationBuilder.DropColumn(
                name: "ass1ID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "ass2ID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "ass3ID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "quiz1ID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "quiz2ID",
                table: "Finals");

            migrationBuilder.DropColumn(
                name: "quiz3ID",
                table: "Finals");
        }
    }
}
