using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class DefaultPlant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb4ae189-eae3-495c-b5bb-8da37c817613");

            migrationBuilder.DropColumn(
                name: "PlantCare",
                table: "DefaultPlant");

            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "Plant",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlantCare",
                table: "Plant",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "DefaultPlant",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Issues",
                table: "DefaultPlant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sunlight",
                table: "DefaultPlant",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Temperature",
                table: "DefaultPlant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "DefaultPlant",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "349c3bb2-59ca-4e2e-b44d-b068fcbcf697", 0, "bbc65580-7e56-4ff7-8381-2655951fcd2d", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECKAogWDIL/ugaiJWOouNQp0xisb+37u4KRmrf8hBNARvTxoGFo9lTmnQQdEaxzbyw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ", "Bright, indirect sunlight or artifical sunlight.", "55-80 degrees F.", "Once every 3-4 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Usually pest free.", "Partial sun or shade.", "65-80 degrees F.", "Once every 3-4 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Black spots caused from insects, viruses, and fungal disease.", "Full sun for at least 4 hours each day.", "65-70 degrees F.", "Once every 2-3 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Basal stem rot and Botryis.", "Bright light to full sun.", "65-70 degrees F.", "Once every 2-3 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering and Mealy bugs.", "Full sun for at least 4 hours each day.", "65-75 degrees F.", "Once every 4 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering and Mealybugs, scale, red spidermites.", "Bright light to full sun.", "60-75 degrees F.", "Once every 10 days." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Mealybugs, scale, red spidermites, and overwatering.", "Partial shade to full sun.", "60-80 degrees F.", "Once every 1-2 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering, Mealybugs, and scale bugs.", "Direct sunlight.", "50-75 degrees F.", "Once every 2-3 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Fungal problems, such as southern blight and red leaf spot.", "low light, full light and indirect sunlight.", "70-90 degrees F.", "Once every 2-6 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering causing root rot.", "Full sunlight.", "65-75 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Powdery mildrew, botrytis, and root rot.", "Full sunlight.", "-35-40 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "none.", "Full sun or lightly filtered shade.", "10-70 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Sucking pests, fungal and bacteria disease.", "Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.", "45-85 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Mealy bugs.", "Full to partial sun.", "35-50 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Ants, Mealy bugs, snails, slugs, and overwatering.", "Full sun and partial sun in afternoons.", "18-50 degrees F.", "Once a month." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Snails, slugs, and overwatering.", "Full sun to partial shade.", "18-22 degrees F.", "1-2 times a month." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot caused by overwatering.", "Full sun to partial shade.", "65-75 degrees F.", "Once every 10 days." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot from overwatering.", "Full sun for 6 hours at least.", "40-100 degrees F.", "1-2 times a month." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot and leaf rot from overwatering.", "Bright sunlight for a minimum of four hours a day.", "60-80 degrees F.", "Once a month." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot caused by overwatering.", "At least 3-4 hours of direct full sunlight.", "35-80 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot caused by overwatering and toxic to humans and animals.", "At least 6 hours of direct full sunlight.", "25-50 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Stem base rot and brown spots.", "At least 4-5 hours of morning sunlight and partial shade in the afternoon.", "45-100 degrees F.", "Once every 3-4 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering.", "Full sun to filtered/partial shade.", "40-80 degrees F.", "Once every 2-3 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering, spidermites, scale, or mealybugs.", "full sun or bright, indirect light.", "45-55 degrees F.", "Once every 3-4 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Fungal disease caused by overwatering.", "Bright shaded areas.", "20-30 degrees F.", "Once a week." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Mealy bugs and scale.", "Full to partial sun.", "-20-40 degrees F.", "Once every 7-10 days." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering.", "At least 6 hours of direct full/partial sunlight.", "20-50 degrees F.", "Once every week; less in the winter." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Overwatering and sudden leaf wilting.", "At least 3-4 hours of direct sunlight.", "70-90 degrees F.", "Once a weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Root rot.", "Full sun.", "12-112 degrees F.", "Once every 2-3 weeks." });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Issues", "Sunlight", "Temperature", "Water" },
                values: new object[] { "Spider mites.", "At least 4-5 hours of morning sunlight and partial shade in the afternoon.", "65-75 degrees F.", "Once every 2-3 weeks." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "349c3bb2-59ca-4e2e-b44d-b068fcbcf697");

            migrationBuilder.DropColumn(
                name: "Issues",
                table: "DefaultPlant");

            migrationBuilder.DropColumn(
                name: "Sunlight",
                table: "DefaultPlant");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "DefaultPlant");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "DefaultPlant");

            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PlantCare",
                table: "Plant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "DefaultPlant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "PlantCare",
                table: "DefaultPlant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "fb4ae189-eae3-495c-b5bb-8da37c817613", 0, "db47527e-2604-4caa-94b0-be0f353d47a1", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHE73KzlVO7n9Vwzr1eY3OMFJ9JNw/7s9mKI0BYAUGMzgVRJzcjHEljLqfT4juKLzQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlantCare",
                value: "Light: Bright, indirect sunlight or artifical sunlight. Temp:55-80 degrees F.Water:Once every 3-4 weeks.Issues:Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlantCare",
                value: "Light:Partial sun or shade. Temp:65-80 degrees F.Water:Once every 3-4 weeks. Issues:Usually pest free.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlantCare",
                value: "Light:Full sun for at least 4 hours each day. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Black spots caused from insects, viruses, and fungal disease.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlantCare",
                value: "Light:Bright light to full sun. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Basal stem rot and Botryis .");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlantCare",
                value: "Light:Full sun for at least 4 hours each day. Temp:65-75 degrees F.Water:Once every 4 weeks.Issues:Overwatering and Mealy bugs.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlantCare",
                value: "Light:Bright light to full sun. Temp:60-75 degrees F.Water:Once every 10 days.Issues:Overwatering and Mealybugs, scale, red spidermites.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlantCare",
                value: "Light:Partial shade to full sun. Temp:60-80 degrees F.Water:Once every 1-2 weeks.Issues:Mealybugs, scale, red spidermites, and overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 8,
                column: "PlantCare",
                value: "Light:Direct sunlight. Temp:50-75 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering, Mealybugs, and scale bugs.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 9,
                column: "PlantCare",
                value: "Light:low light, full light and indirect sunlight. Temp:70-90 degrees F.Water:Once every 2-6 weeks.Issues:Fungal problems, such as southern blight and red leaf spot.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlantCare",
                value: "Light:Full sunlight. Temp:65-75 degrees F.Water:Once a week.Issues:Overwatering causing root rot.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 11,
                column: "PlantCare",
                value: "Light:Full sunlight. Temp:-35-40 degrees F.Water:Once a week.Issues:Powdery mildrew, botrytis, and root rot.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 12,
                column: "PlantCare",
                value: "Light:Full sun or lightly filtered shade. Temp:10-70 degrees F.Water:Once a week.Issues:none.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 13,
                column: "PlantCare",
                value: "Light:Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.Temp:45-85 degrees F.Water:Once a week.Issues:Sucking pests, fungal and bacteria disease.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 14,
                column: "PlantCare",
                value: "Light: Full to partial sun.Temp:35-50 degrees F.Water:Once a week.Issues:Mealy bugs.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 15,
                column: "PlantCare",
                value: "Light: Full sun and partial sun in afternoons.Temp:18-50 degrees F.Water:Once a month.Issues:Ants, Mealy bugs, snails, slugs, and overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 16,
                column: "PlantCare",
                value: "Light: Full sun to partial shade.Temp:18-22 degrees F.Water:1-2 times a month.Issues:Snails, slugs, and overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 17,
                column: "PlantCare",
                value: "Light: Full sun to partial shade.Temp:65-75 degrees F.Water:Once every 10 days.Issues:Root rot caused by overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 18,
                column: "PlantCare",
                value: "Light: Full sun for 6 hours at least.Temp:40-100 degrees F.Water:1-2 times a month.Issues:Root rot from overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 19,
                column: "PlantCare",
                value: "Light:Bright sunlight for a minimum of four hours a day.Temp:60-80 degrees F.Water:Once a month.Issues:Root rot and leaf rot from overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 20,
                column: "PlantCare",
                value: "Light:At least 3-4 hours of direct full sunlight.Temp:35-80 degrees F.Water:Once a week.Issues:Root rot caused by overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 21,
                column: "PlantCare",
                value: "Light:At least 6 hours of direct full sunlight.Temp:25-50 degrees F.Water:Once a week.Issues:Root rot caused by overwatering and toxic to humans and animals.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 22,
                column: "PlantCare",
                value: "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:45-100 degrees F.Water:Once every 3-4 weeks.Issues:Stem base rot and brown spots.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 23,
                column: "PlantCare",
                value: "Light:Full sun to filtered/partial shade.Temp:40-80 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 24,
                column: "PlantCare",
                value: "full sun or bright, indirect light.Temp:45-55 degrees F.Water:Once every 3-4 weeks.Issues:overwatering, spidermites, scale, or mealybugs.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 25,
                column: "PlantCare",
                value: "Light:Bright shaded areas.Temp:20-30 degrees F.Water:Once a week.Issues:Fungal disease caused by overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 26,
                column: "PlantCare",
                value: "Light: Full to partial sun.Temp:-20-40 degrees F.Water:Once every 7-10 days.Issues:Mealy bugs and scale.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 27,
                column: "PlantCare",
                value: "Light:At least 6 hours of direct full/partial sunlight.Temp:20-50 degrees F.Water:Once every week; less in the winter.Issues:Overwatering.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 28,
                column: "PlantCare",
                value: "Light:At least 3-4 hours of direct sunlight.Temp:70-90 degrees F.Water:Once a weeks.Issues:Overwatering and sudden leaf wilting.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 29,
                column: "PlantCare",
                value: "Light: Full sun.Temp: 12-112 degrees F.Water:Once every 2-3 weeks.Issues:Root rot.");

            migrationBuilder.UpdateData(
                table: "DefaultPlant",
                keyColumn: "Id",
                keyValue: 30,
                column: "PlantCare",
                value: "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:65-75 degrees F.Water:Once every 2-3 weeks.Issues:Spider mites.");
        }
    }
}
