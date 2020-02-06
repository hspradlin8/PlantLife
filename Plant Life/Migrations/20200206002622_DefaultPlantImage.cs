using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class DefaultPlantImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sunlight",
                table: "Plant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sunlight",
                table: "DefaultPlant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c766527-964c-4713-bda4-c2871b0cbdd2", "AQAAAAEAACcQAAAAEG4UxAfQh3N0u8VVYPQadDbuMkRBee0splIHWN+peAf3G7dJZoMjC/sdR+KdF8omhw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sunlight",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sunlight",
                table: "DefaultPlant",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdff27fd-d60c-404a-b172-17fdc53d6818", "AQAAAAEAACcQAAAAEGPNXbEhQu/oxb8YOr12czFFNRuBRN3u4Yr1yNgS8RY8I7yKY8unA6Yh0pRWjiF0jw==" });
        }
    }
}
