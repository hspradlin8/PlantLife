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
                    PlantName = table.Column<string>(nullable: false),
                    Sunlight = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true),
                    Water = table.Column<string>(nullable: true),
                    WaterNeeds = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Issues = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultPlant", x => x.Id);
                });

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
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    EventName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    PlantId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_ApplicationUserId",
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

            migrationBuilder.CreateTable(
                name: "DefaultPlantUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    DefaultPlantId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    PlantIndexViewModelId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_DefaultPlantUser_DefaultPlant_DefaultPlantId",
                        column: x => x.DefaultPlantId,
                        principalTable: "DefaultPlant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefaultPlantUser_PlantIndexViewModel_PlantIndexViewModelId",
                        column: x => x.PlantIndexViewModelId,
                        principalTable: "PlantIndexViewModel",
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
                    PlantName = table.Column<string>(nullable: false),
                    Sunlight = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true),
                    Water = table.Column<string>(nullable: true),
                    WaterNeeds = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Issues = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Image = table.Column<string>(nullable: true),
                    PlantIndexViewModelId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Plant_PlantIndexViewModel_PlantIndexViewModelId",
                        column: x => x.PlantIndexViewModelId,
                        principalTable: "PlantIndexViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "0290a6ab-6561-4608-bcbf-6090abe96456", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELQTb27q/8ywFfXJkT8ng1fhf5MlfjXGd3Q8M5KyS0yVWFRboWj7EaIiEX2kJAnlcA==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "DefaultPlant",
                columns: new[] { "Id", "Description", "Image", "Issues", "PlantName", "Quantity", "Sunlight", "Temperature", "Water", "WaterNeeds" },
                values: new object[,]
                {
                    { 28, null, null, "Overwatering and sudden leaf wilting.", "Tigers Jaw Plant", 0, "At least 3-4 hours of direct sunlight.", "70-90 degrees F.", "Once a weeks.", 0 },
                    { 27, null, null, "Overwatering.", "Mexican Snowball", 0, "At least 6 hours of direct full/partial sunlight.", "20-50 degrees F.", "Once every week; less in the winter.", 0 },
                    { 26, null, null, "Mealy bugs and scale.", "Tufted Ice Plant", 0, "Full to partial sun.", "-20-40 degrees F.", "Once every 7-10 days.", 0 },
                    { 25, null, null, "Fungal disease caused by overwatering.", "Bear's Paw", 0, "Bright shaded areas.", "20-30 degrees F.", "Once a week.", 0 },
                    { 24, null, null, "Overwatering, spidermites, scale, or mealybugs.", "Ponytail Palm", 0, "full sun or bright, indirect light.", "45-55 degrees F.", "Once every 3-4 weeks.", 0 },
                    { 23, null, null, "Overwatering.", "Doran Black Aloe", 0, "Full sun to filtered/partial shade.", "40-80 degrees F.", "Once every 2-3 weeks.", 0 },
                    { 22, null, null, "Stem base rot and brown spots.", "Bunny Ears Cactus", 0, "At least 4-5 hours of morning sunlight and partial shade in the afternoon.", "45-100 degrees F.", "Once every 3-4 weeks.", 0 },
                    { 21, null, null, "Root rot caused by overwatering and toxic to humans and animals.", "Calico Hearts Plant", 0, "At least 6 hours of direct full sunlight.", "25-50 degrees F.", "Once a week.", 0 },
                    { 20, null, null, "Root rot caused by overwatering.", "Crown of Thorns", 0, "At least 3-4 hours of direct full sunlight.", "35-80 degrees F.", "Once a week.", 0 },
                    { 19, null, null, "Root rot and leaf rot from overwatering.", "Torch Cactus", 0, "Bright sunlight for a minimum of four hours a day.", "60-80 degrees F.", "Once a month.", 0 },
                    { 18, null, null, "Root rot from overwatering.", "Sunburst Plant", 0, "Full sun for 6 hours at least.", "40-100 degrees F.", "1-2 times a month.", 0 },
                    { 17, null, null, "Root rot caused by overwatering.", "Zwartkop Plant", 0, "Full sun to partial shade.", "65-75 degrees F.", "Once every 10 days.", 0 },
                    { 16, null, null, "Snails, slugs, and overwatering.", "Pig's Ear", 0, "Full sun to partial shade.", "18-22 degrees F.", "1-2 times a month.", 0 },
                    { 29, null, null, "Root rot.", "Ghost Plant", 0, "Full sun.", "12-112 degrees F.", "Once every 2-3 weeks.", 0 },
                    { 15, null, null, "Ants, Mealy bugs, snails, slugs, and overwatering.", "Dudleya Plant", 0, "Full sun and partial sun in afternoons.", "18-50 degrees F.", "Once a month.", 0 },
                    { 13, null, null, "Sucking pests, fungal and bacteria disease.", "Ball Cactus", 0, "Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.", "45-85 degrees F.", "Once a week.", 0 },
                    { 12, null, null, "none.", "Whale's Tongue Agave", 0, "Full sun or lightly filtered shade.", "10-70 degrees F.", "Once a week.", 0 },
                    { 11, null, null, "Powdery mildrew, botrytis, and root rot.", "Stonecrop", 0, "Full sunlight.", "-35-40 degrees F.", "Once a week.", 0 },
                    { 10, null, null, "Overwatering causing root rot.", "Hens-and-Chicks", 0, "Full sunlight.", "65-75 degrees F.", "Once a week.", 0 },
                    { 9, null, null, "Fungal problems, such as southern blight and red leaf spot.", "Snake Plant", 0, "low light, full light and indirect sunlight.", "70-90 degrees F.", "Once every 2-6 weeks.", 0 },
                    { 8, null, null, "Overwatering, Mealybugs, and scale bugs.", "Pincushion Cactus", 0, "Direct sunlight.", "50-75 degrees F.", "Once every 2-3 weeks.", 0 },
                    { 7, null, null, "Mealybugs, scale, red spidermites, and overwatering.", "Roseum", 0, "Partial shade to full sun.", "60-80 degrees F.", "Once every 1-2 weeks.", 0 },
                    { 6, null, null, "Overwatering and Mealybugs, scale, red spidermites.", "Panda Plant", 0, "Bright light to full sun.", "60-75 degrees F.", "Once every 10 days.", 0 },
                    { 5, null, null, "Overwatering and Mealy bugs.", "Burro's Tail", 0, "Full sun for at least 4 hours each day.", "65-75 degrees F.", "Once every 4 weeks.", 0 },
                    { 4, null, null, "Basal stem rot and Botryis.", "Flaming Katy", 0, "Bright light to full sun.", "65-70 degrees F.", "Once every 2-3 weeks.", 0 },
                    { 3, null, null, "Black spots caused from insects, viruses, and fungal disease.", "Jade Plant", 0, "Full sun for at least 4 hours each day.", "65-70 degrees F.", "Once every 2-3 weeks.", 0 },
                    { 2, null, null, "Usually pest free.", "Zebra Plant", 0, "Partial sun or shade.", "65-80 degrees F.", "Once every 3-4 weeks.", 0 },
                    { 1, null, null, "Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ", "Aloe Vera", 0, "Bright, indirect sunlight or artifical sunlight.", "55-80 degrees F.", "Once every 3-4 weeks.", 0 },
                    { 14, null, null, "Mealy bugs.", "Plush Plant", 0, "Full to partial sun.", "35-50 degrees F.", "Once a week.", 0 },
                    { 30, null, null, "Spider mites.", "Living Stone", 0, "At least 4-5 hours of morning sunlight and partial shade in the afternoon.", "65-75 degrees F.", "Once every 2-3 weeks.", 0 }
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
                name: "IX_DefaultPlantUser_DefaultPlantId",
                table: "DefaultPlantUser",
                column: "DefaultPlantId");

            migrationBuilder.CreateIndex(
                name: "IX_DefaultPlantUser_PlantIndexViewModelId",
                table: "DefaultPlantUser",
                column: "PlantIndexViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_ApplicationUserId",
                table: "Plant",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_PlantIndexViewModelId",
                table: "Plant",
                column: "PlantIndexViewModelId");

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
                name: "DefaultPlantUser");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "PlantCalendar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DefaultPlant");

            migrationBuilder.DropTable(
                name: "PlantIndexViewModel");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
