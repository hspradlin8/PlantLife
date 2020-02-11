using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class WaterNeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Event",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "075f9e27-4f46-4b73-8d27-6a4e9dee1abb", "AQAAAAEAACcQAAAAEI2zI9x7SLuIILpGlEVL0AEERT76yGNHEm+qfTuV/gzRUVCCU+jm1LvMgteaDtaNLw==" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a month", null, 3 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 1 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { "Times a week", null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Event_PlantId",
                table: "Event",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_PlantId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Event",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Event",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0290a6ab-6561-4608-bcbf-6090abe96456", "AQAAAAEAACcQAAAAELQTb27q/8ywFfXJkT8ng1fhf5MlfjXGd3Q8M5KyS0yVWFRboWj7EaIiEX2kJAnlcA==" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 3-4 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 3-4 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 4 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 10 days.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 1-2 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-6 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a month.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "1-2 times a month.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 10 days.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "1-2 times a month.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a month.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 3-4 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 3-4 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a week.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 7-10 days.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every week; less in the winter.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once a weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Water", "WaterNeeds" },
                values: new object[] { null, "Once every 2-3 weeks.", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
