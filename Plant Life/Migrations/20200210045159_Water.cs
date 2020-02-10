using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class Water : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WaterNeeds",
                table: "Plant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WaterNeeds",
                table: "DefaultPlant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2de8d71-dff5-42c0-be4d-5e48f57a7b0d", "AQAAAAEAACcQAAAAEGlyv99UqjUSMvuezcwhnaRh4eqAWKQCyDCV9+eC2DR+zgt+YHo0iK15jEbAP3mFcQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WaterNeeds",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "WaterNeeds",
                table: "DefaultPlant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79b62735-d10c-4564-a1d0-75617af2b819", "AQAAAAEAACcQAAAAEDU2eb9BzbL4ZcgiNWojMn4QcU0ZHuOquOj09QGsa4oK+DzMddABR1gcQwO5ytbXeQ==" });
        }
    }
}
