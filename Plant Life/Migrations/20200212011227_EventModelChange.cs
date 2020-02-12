using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class EventModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Event",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee0c47e3-9309-4ffd-9e9d-b85df74e1d0d", "AQAAAAEAACcQAAAAEM3f1jvlyNCuglHz2d5RAkVSY9acPLOjDsdxLZrLICqhKHLWQUl5KXKcxHt5XoTPZg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Event",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e01ed63-1895-4fdf-aa14-df631ac4d51d", "AQAAAAEAACcQAAAAEAi+XLVfxfeoOEzDhFhBffY2I/glE61ekciT0uHZQvp9uHbAWDkdNXnFCfxyNT/vbA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Plant_PlantId",
                table: "Event",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
