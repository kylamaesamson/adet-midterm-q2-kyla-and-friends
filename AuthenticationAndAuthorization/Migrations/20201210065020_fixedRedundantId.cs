using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class fixedRedundantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ass1ID",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Ass2ID",
                table: "GradesPerTerms");

            migrationBuilder.DropColumn(
                name: "Ass3ID",
                table: "GradesPerTerms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d6e950-7764-4852-b517-422544f8dea0", "AQAAAAEAACcQAAAAEGlnModKQUMiVd1xzW/+IpTCz5+iMDEwipQZUirR4K7ASEBjRBkIaJ1xQd9b6rwzYA==", "56836108-0db7-432a-9b9a-711a8ea66411" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ass1ID",
                table: "GradesPerTerms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ass2ID",
                table: "GradesPerTerms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ass3ID",
                table: "GradesPerTerms",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71fac4eb-622a-4572-bdce-f0eb0316f7da", "AQAAAAEAACcQAAAAEEPSpLMZ6y4HqEffHzn+I7stEPvtWT6tcbhnG5HUAxRgzlB5iRtqcxVZk9tEhhrq2A==", "d18776a4-1505-473d-a1ee-8b7ed6f7abbf" });
        }
    }
}
