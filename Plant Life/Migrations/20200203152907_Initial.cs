using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant_Life.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefaultPlant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true),
                    PlantCare = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultPlant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: false),
                    UserPlantId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendar_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefaultPlantUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    DefaultPlantId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultPlantUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefaultPlantUser_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    PlantName = table.Column<string>(nullable: true),
                    PlantCare = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plant_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlantCalendar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: false),
                    CalendarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantCalendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantCalendar_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "fb4ae189-eae3-495c-b5bb-8da37c817613", 0, "db47527e-2604-4caa-94b0-be0f353d47a1", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHE73KzlVO7n9Vwzr1eY3OMFJ9JNw/7s9mKI0BYAUGMzgVRJzcjHEljLqfT4juKLzQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "DefaultPlant",
                columns: new[] { "Id", "Image", "PlantCare", "PlantName", "Quantity" },
                values: new object[,]
                {
                    { 28, null, "Light:At least 3-4 hours of direct sunlight.Temp:70-90 degrees F.Water:Once a weeks.Issues:Overwatering and sudden leaf wilting.", "Tigers Jaw Plant", 0 },
                    { 27, null, "Light:At least 6 hours of direct full/partial sunlight.Temp:20-50 degrees F.Water:Once every week; less in the winter.Issues:Overwatering.", "Mexican Snowball", 0 },
                    { 26, null, "Light: Full to partial sun.Temp:-20-40 degrees F.Water:Once every 7-10 days.Issues:Mealy bugs and scale.", "Tufted Ice Plant", 0 },
                    { 25, null, "Light:Bright shaded areas.Temp:20-30 degrees F.Water:Once a week.Issues:Fungal disease caused by overwatering.", "Bear's Paw", 0 },
                    { 24, null, "full sun or bright, indirect light.Temp:45-55 degrees F.Water:Once every 3-4 weeks.Issues:overwatering, spidermites, scale, or mealybugs.", "Ponytail Palm", 0 },
                    { 23, null, "Light:Full sun to filtered/partial shade.Temp:40-80 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering.", "Doran Black Aloe", 0 },
                    { 22, null, "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:45-100 degrees F.Water:Once every 3-4 weeks.Issues:Stem base rot and brown spots.", "Bunny Ears Cactus", 0 },
                    { 21, null, "Light:At least 6 hours of direct full sunlight.Temp:25-50 degrees F.Water:Once a week.Issues:Root rot caused by overwatering and toxic to humans and animals.", "Calico Hearts Plant", 0 },
                    { 20, null, "Light:At least 3-4 hours of direct full sunlight.Temp:35-80 degrees F.Water:Once a week.Issues:Root rot caused by overwatering.", "Crown of Thorns", 0 },
                    { 19, null, "Light:Bright sunlight for a minimum of four hours a day.Temp:60-80 degrees F.Water:Once a month.Issues:Root rot and leaf rot from overwatering.", "Torch Cactus", 0 },
                    { 18, null, "Light: Full sun for 6 hours at least.Temp:40-100 degrees F.Water:1-2 times a month.Issues:Root rot from overwatering.", "Sunburst Plant", 0 },
                    { 17, null, "Light: Full sun to partial shade.Temp:65-75 degrees F.Water:Once every 10 days.Issues:Root rot caused by overwatering.", "Zwartkop Plant", 0 },
                    { 16, null, "Light: Full sun to partial shade.Temp:18-22 degrees F.Water:1-2 times a month.Issues:Snails, slugs, and overwatering.", "Pig's Ear", 0 },
                    { 29, null, "Light: Full sun.Temp: 12-112 degrees F.Water:Once every 2-3 weeks.Issues:Root rot.", "Ghost Plant", 0 },
                    { 15, null, "Light: Full sun and partial sun in afternoons.Temp:18-50 degrees F.Water:Once a month.Issues:Ants, Mealy bugs, snails, slugs, and overwatering.", "Dudleya Plant", 0 },
                    { 13, null, "Light:Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.Temp:45-85 degrees F.Water:Once a week.Issues:Sucking pests, fungal and bacteria disease.", "Ball Cactus", 0 },
                    { 12, null, "Light:Full sun or lightly filtered shade. Temp:10-70 degrees F.Water:Once a week.Issues:none.", "Whale's Tongue Agave", 0 },
                    { 11, null, "Light:Full sunlight. Temp:-35-40 degrees F.Water:Once a week.Issues:Powdery mildrew, botrytis, and root rot.", "Stonecrop", 0 },
                    { 10, null, "Light:Full sunlight. Temp:65-75 degrees F.Water:Once a week.Issues:Overwatering causing root rot.", "Hens-and-Chicks", 0 },
                    { 9, null, "Light:low light, full light and indirect sunlight. Temp:70-90 degrees F.Water:Once every 2-6 weeks.Issues:Fungal problems, such as southern blight and red leaf spot.", "Snake Plant", 0 },
                    { 8, null, "Light:Direct sunlight. Temp:50-75 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering, Mealybugs, and scale bugs.", "Pincushion Cactus", 0 },
                    { 7, null, "Light:Partial shade to full sun. Temp:60-80 degrees F.Water:Once every 1-2 weeks.Issues:Mealybugs, scale, red spidermites, and overwatering.", "Roseum", 0 },
                    { 6, null, "Light:Bright light to full sun. Temp:60-75 degrees F.Water:Once every 10 days.Issues:Overwatering and Mealybugs, scale, red spidermites.", "Panda Plant", 0 },
                    { 5, null, "Light:Full sun for at least 4 hours each day. Temp:65-75 degrees F.Water:Once every 4 weeks.Issues:Overwatering and Mealy bugs.", "Burro's Tail", 0 },
                    { 4, null, "Light:Bright light to full sun. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Basal stem rot and Botryis .", "Flaming Katy", 0 },
                    { 3, null, "Light:Full sun for at least 4 hours each day. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Black spots caused from insects, viruses, and fungal disease.", "Jade Plant", 0 },
                    { 2, null, "Light:Partial sun or shade. Temp:65-80 degrees F.Water:Once every 3-4 weeks. Issues:Usually pest free.", "Zebra Plant", 0 },
                    { 1, null, "Light: Bright, indirect sunlight or artifical sunlight. Temp:55-80 degrees F.Water:Once every 3-4 weeks.Issues:Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ", "Aloe Vera", 0 },
                    { 14, null, "Light: Full to partial sun.Temp:35-50 degrees F.Water:Once a week.Issues:Mealy bugs.", "Plush Plant", 0 },
                    { 30, null, "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:65-75 degrees F.Water:Once every 2-3 weeks.Issues:Spider mites.", "Living Stone", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_ApplicationUserId",
                table: "Calendar",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DefaultPlantUser_ApplicationUserId",
                table: "DefaultPlantUser",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_ApplicationUserId",
                table: "Plant",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantCalendar_ApplicationUserId",
                table: "PlantCalendar",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "DefaultPlant");

            migrationBuilder.DropTable(
                name: "DefaultPlantUser");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "PlantCalendar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
