using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class Water : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Water",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "DefaultPlant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e01ed63-1895-4fdf-aa14-df631ac4d51d", "AQAAAAEAACcQAAAAEAi+XLVfxfeoOEzDhFhBffY2I/glE61ekciT0uHZQvp9uHbAWDkdNXnFCfxyNT/vbA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "DefaultPlant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1a73ed0-524f-4d5f-9fb8-87026d85ab4b", "AQAAAAEAACcQAAAAEH7kg7v95FuUsTRRl2o96zxdUxdbYN3lNdm7KlEPAbBlX73XDQWNBNPJ1jHqdoDWhg==" });
        }
    }
}
