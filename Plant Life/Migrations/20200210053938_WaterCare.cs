using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class WaterCare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Plant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DefaultPlant",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "696e3c40-645c-4471-943e-322deaaa7a73", "AQAAAAEAACcQAAAAEObTm5Bb8j3kWXVUqQE5hjvd7sEimvV1Estx9xFm13/43IfE/U6qEOdmTJJtoGzTuw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b2de8d71-dff5-42c0-be4d-5e48f57a7b0d", "AQAAAAEAACcQAAAAEGlyv99UqjUSMvuezcwhnaRh4eqAWKQCyDCV9+eC2DR+zgt+YHo0iK15jEbAP3mFcQ==" });
        }
    }
}
