using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class initGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71fac4eb-622a-4572-bdce-f0eb0316f7da", "AQAAAAEAACcQAAAAEEPSpLMZ6y4HqEffHzn+I7stEPvtWT6tcbhnG5HUAxRgzlB5iRtqcxVZk9tEhhrq2A==", "d18776a4-1505-473d-a1ee-8b7ed6f7abbf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a486a394-e315-4d90-a127-96c2755382e7", "AQAAAAEAACcQAAAAEAO/iw/B5xjFKlYvg+sarjWrNdmQ+mzuFjVkyWIDQmY7mTwO1tHqFqPKPm/ABCiPYw==", "094a9cd7-037a-4a00-9957-6997cd09fc36" });
        }
    }
}
