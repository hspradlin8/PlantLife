using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class EventModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88f0dc7b-6280-497c-8389-7fc93c5726ef", "AQAAAAEAACcQAAAAEABbWJvY4S4id/P80ngZ2oifebP/H3g/PZ/KfFzDqacutoO73vx9TVxOBxtuSZ6fpQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5c32cdc-9f64-46e1-b1fc-d966e133e61e", "AQAAAAEAACcQAAAAEJYlO1ByfXGO0XBJLQMuLC4YzfYyYJBRv9zQI4044UMhKB3ZCLFSiD8XrYYnNl0k7Q==" });
        }
    }
}
