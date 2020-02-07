using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class DB_Temperature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5c32cdc-9f64-46e1-b1fc-d966e133e61e", "AQAAAAEAACcQAAAAEJYlO1ByfXGO0XBJLQMuLC4YzfYyYJBRv9zQI4044UMhKB3ZCLFSiD8XrYYnNl0k7Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c766527-964c-4713-bda4-c2871b0cbdd2", "AQAAAAEAACcQAAAAEG4UxAfQh3N0u8VVYPQadDbuMkRBee0splIHWN+peAf3G7dJZoMjC/sdR+KdF8omhw==" });
        }
    }
}
