using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationAndAuthorization.Migrations
{
    public partial class addedItemScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "ItemScores",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "737b15d4-2bc8-4f06-acf4-c5adb788f44b", "AQAAAAEAACcQAAAAEH6d3pzawreyNDAhAd27xfB6VXfIdIYLfcUCl+BjmUDGchojGYgPLQjje2gERNkUXw==", "f10f8887-6b1e-4e6e-b70d-3cddda8d2eb8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Grade",
                table: "ItemScores",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad3430d8-80bb-4e33-9ad3-7157d625d3ab", "AQAAAAEAACcQAAAAEIwbyYZdRtL5iWevNfbSJ8s7+YynoS2LKNV0njcrisWmhaLSY+M/Be5+YqrKkCls1g==", "5baed936-55db-43e9-a260-607987648dad" });
        }
    }
}
