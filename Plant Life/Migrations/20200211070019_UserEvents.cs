using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class UserEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlantIndexViewModelId",
                table: "Event",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1a73ed0-524f-4d5f-9fb8-87026d85ab4b", "AQAAAAEAACcQAAAAEH7kg7v95FuUsTRRl2o96zxdUxdbYN3lNdm7KlEPAbBlX73XDQWNBNPJ1jHqdoDWhg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_PlantIndexViewModelId",
                table: "Event",
                column: "PlantIndexViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_PlantIndexViewModel_PlantIndexViewModelId",
                table: "Event",
                column: "PlantIndexViewModelId",
                principalTable: "PlantIndexViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_PlantIndexViewModel_PlantIndexViewModelId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_PlantIndexViewModelId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PlantIndexViewModelId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "075f9e27-4f46-4b73-8d27-6a4e9dee1abb", "AQAAAAEAACcQAAAAEI2zI9x7SLuIILpGlEVL0AEERT76yGNHEm+qfTuV/gzRUVCCU+jm1LvMgteaDtaNLw==" });
        }
    }
}
