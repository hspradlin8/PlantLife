using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class DateInterval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DefaultPlant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d55c04fa-6b2c-4343-a1b9-eabb1e703cba", "AQAAAAEAACcQAAAAELmyvUNi9ZDrIhNWFtpTzS3rXSXEFhHiOsx02mGRYkoQkvvEnKMYzQ+YEMFXCPGGQQ==" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                column: "WaterNeeds",
                value: 5);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                column: "WaterNeeds",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                column: "WaterNeeds",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                column: "WaterNeeds",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                column: "WaterNeeds",
                value: 6);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                column: "WaterNeeds",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                column: "WaterNeeds",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                column: "WaterNeeds",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                column: "WaterNeeds",
                value: 10);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                column: "WaterNeeds",
                value: 5);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                column: "WaterNeeds",
                value: 8);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                column: "WaterNeeds",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                column: "WaterNeeds",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                column: "WaterNeeds",
                value: 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DefaultPlant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee0c47e3-9309-4ffd-9e9d-b85df74e1d0d", "AQAAAAEAACcQAAAAEM3f1jvlyNCuglHz2d5RAkVSY9acPLOjDsdxLZrLICqhKHLWQUl5KXKcxHt5XoTPZg==" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a month", 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "WaterNeeds" },
                values: new object[] { "Times a week", 2 });
        }
    }
}
