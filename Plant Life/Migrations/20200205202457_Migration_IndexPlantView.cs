using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class Migration_IndexPlantView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlantCare",
                table: "Plant");

            migrationBuilder.AddColumn<string>(
                name: "Issues",
                table: "Plant",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlantIndexViewModelId",
                table: "Plant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunlight",
                table: "Plant",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Temperature",
                table: "Plant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "Plant",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlantIndexViewModelId",
                table: "DefaultPlantUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlantIndexViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantIndexViewModel", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdff27fd-d60c-404a-b172-17fdc53d6818", "AQAAAAEAACcQAAAAEGPNXbEhQu/oxb8YOr12czFFNRuBRN3u4Yr1yNgS8RY8I7yKY8unA6Yh0pRWjiF0jw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Plant_PlantIndexViewModelId",
                table: "Plant",
                column: "PlantIndexViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DefaultPlantUser_PlantIndexViewModelId",
                table: "DefaultPlantUser",
                column: "PlantIndexViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefaultPlantUser_PlantIndexViewModel_PlantIndexViewModelId",
                table: "DefaultPlantUser",
                column: "PlantIndexViewModelId",
                principalTable: "PlantIndexViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plant_PlantIndexViewModel_PlantIndexViewModelId",
                table: "Plant",
                column: "PlantIndexViewModelId",
                principalTable: "PlantIndexViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefaultPlantUser_PlantIndexViewModel_PlantIndexViewModelId",
                table: "DefaultPlantUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Plant_PlantIndexViewModel_PlantIndexViewModelId",
                table: "Plant");

            migrationBuilder.DropTable(
                name: "PlantIndexViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Plant_PlantIndexViewModelId",
                table: "Plant");

            migrationBuilder.DropIndex(
                name: "IX_DefaultPlantUser_PlantIndexViewModelId",
                table: "DefaultPlantUser");

            migrationBuilder.DropColumn(
                name: "Issues",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "PlantIndexViewModelId",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Sunlight",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "PlantIndexViewModelId",
                table: "DefaultPlantUser");

            migrationBuilder.AddColumn<string>(
                name: "PlantCare",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bb712cb-688c-4d71-8938-ea99b1213e9c", "AQAAAAEAACcQAAAAEN2oSFSSvRq0kf4Cn59IvQVDMP5zznoMpPPgnDTyfrDapfhTLHWFQC9Vg6y+9n/8+Q==" });
        }
    }
}
