﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plant_Life.Data;

namespace Plant_Life.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Plant_Life.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserPlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("Plant_Life.Models.DefaultPlant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Issues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Sunlight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Water")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DefaultPlant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Issues = "Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ",
                            PlantName = "Aloe Vera",
                            Quantity = 0,
                            Sunlight = "Bright, indirect sunlight or artifical sunlight.",
                            Temperature = "55-80 degrees F.",
                            Water = "Once every 3-4 weeks."
                        },
                        new
                        {
                            Id = 2,
                            Issues = "Usually pest free.",
                            PlantName = "Zebra Plant",
                            Quantity = 0,
                            Sunlight = "Partial sun or shade.",
                            Temperature = "65-80 degrees F.",
                            Water = "Once every 3-4 weeks."
                        },
                        new
                        {
                            Id = 3,
                            Issues = "Black spots caused from insects, viruses, and fungal disease.",
                            PlantName = "Jade Plant",
                            Quantity = 0,
                            Sunlight = "Full sun for at least 4 hours each day.",
                            Temperature = "65-70 degrees F.",
                            Water = "Once every 2-3 weeks."
                        },
                        new
                        {
                            Id = 4,
                            Issues = "Basal stem rot and Botryis.",
                            PlantName = "Flaming Katy",
                            Quantity = 0,
                            Sunlight = "Bright light to full sun.",
                            Temperature = "65-70 degrees F.",
                            Water = "Once every 2-3 weeks."
                        },
                        new
                        {
                            Id = 5,
                            Issues = "Overwatering and Mealy bugs.",
                            PlantName = "Burro's Tail",
                            Quantity = 0,
                            Sunlight = "Full sun for at least 4 hours each day.",
                            Temperature = "65-75 degrees F.",
                            Water = "Once every 4 weeks."
                        },
                        new
                        {
                            Id = 6,
                            Issues = "Overwatering and Mealybugs, scale, red spidermites.",
                            PlantName = "Panda Plant",
                            Quantity = 0,
                            Sunlight = "Bright light to full sun.",
                            Temperature = "60-75 degrees F.",
                            Water = "Once every 10 days."
                        },
                        new
                        {
                            Id = 7,
                            Issues = "Mealybugs, scale, red spidermites, and overwatering.",
                            PlantName = "Roseum",
                            Quantity = 0,
                            Sunlight = "Partial shade to full sun.",
                            Temperature = "60-80 degrees F.",
                            Water = "Once every 1-2 weeks."
                        },
                        new
                        {
                            Id = 8,
                            Issues = "Overwatering, Mealybugs, and scale bugs.",
                            PlantName = "Pincushion Cactus",
                            Quantity = 0,
                            Sunlight = "Direct sunlight.",
                            Temperature = "50-75 degrees F.",
                            Water = "Once every 2-3 weeks."
                        },
                        new
                        {
                            Id = 9,
                            Issues = "Fungal problems, such as southern blight and red leaf spot.",
                            PlantName = "Snake Plant",
                            Quantity = 0,
                            Sunlight = "low light, full light and indirect sunlight.",
                            Temperature = "70-90 degrees F.",
                            Water = "Once every 2-6 weeks."
                        },
                        new
                        {
                            Id = 10,
                            Issues = "Overwatering causing root rot.",
                            PlantName = "Hens-and-Chicks",
                            Quantity = 0,
                            Sunlight = "Full sunlight.",
                            Temperature = "65-75 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 11,
                            Issues = "Powdery mildrew, botrytis, and root rot.",
                            PlantName = "Stonecrop",
                            Quantity = 0,
                            Sunlight = "Full sunlight.",
                            Temperature = "-35-40 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 12,
                            Issues = "none.",
                            PlantName = "Whale's Tongue Agave",
                            Quantity = 0,
                            Sunlight = "Full sun or lightly filtered shade.",
                            Temperature = "10-70 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 13,
                            Issues = "Sucking pests, fungal and bacteria disease.",
                            PlantName = "Ball Cactus",
                            Quantity = 0,
                            Sunlight = "Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.",
                            Temperature = "45-85 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 14,
                            Issues = "Mealy bugs.",
                            PlantName = "Plush Plant",
                            Quantity = 0,
                            Sunlight = "Full to partial sun.",
                            Temperature = "35-50 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 15,
                            Issues = "Ants, Mealy bugs, snails, slugs, and overwatering.",
                            PlantName = "Dudleya Plant",
                            Quantity = 0,
                            Sunlight = "Full sun and partial sun in afternoons.",
                            Temperature = "18-50 degrees F.",
                            Water = "Once a month."
                        },
                        new
                        {
                            Id = 16,
                            Issues = "Snails, slugs, and overwatering.",
                            PlantName = "Pig's Ear",
                            Quantity = 0,
                            Sunlight = "Full sun to partial shade.",
                            Temperature = "18-22 degrees F.",
                            Water = "1-2 times a month."
                        },
                        new
                        {
                            Id = 17,
                            Issues = "Root rot caused by overwatering.",
                            PlantName = "Zwartkop Plant",
                            Quantity = 0,
                            Sunlight = "Full sun to partial shade.",
                            Temperature = "65-75 degrees F.",
                            Water = "Once every 10 days."
                        },
                        new
                        {
                            Id = 18,
                            Issues = "Root rot from overwatering.",
                            PlantName = "Sunburst Plant",
                            Quantity = 0,
                            Sunlight = "Full sun for 6 hours at least.",
                            Temperature = "40-100 degrees F.",
                            Water = "1-2 times a month."
                        },
                        new
                        {
                            Id = 19,
                            Issues = "Root rot and leaf rot from overwatering.",
                            PlantName = "Torch Cactus",
                            Quantity = 0,
                            Sunlight = "Bright sunlight for a minimum of four hours a day.",
                            Temperature = "60-80 degrees F.",
                            Water = "Once a month."
                        },
                        new
                        {
                            Id = 20,
                            Issues = "Root rot caused by overwatering.",
                            PlantName = "Crown of Thorns",
                            Quantity = 0,
                            Sunlight = "At least 3-4 hours of direct full sunlight.",
                            Temperature = "35-80 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 21,
                            Issues = "Root rot caused by overwatering and toxic to humans and animals.",
                            PlantName = "Calico Hearts Plant",
                            Quantity = 0,
                            Sunlight = "At least 6 hours of direct full sunlight.",
                            Temperature = "25-50 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 22,
                            Issues = "Stem base rot and brown spots.",
                            PlantName = "Bunny Ears Cactus",
                            Quantity = 0,
                            Sunlight = "At least 4-5 hours of morning sunlight and partial shade in the afternoon.",
                            Temperature = "45-100 degrees F.",
                            Water = "Once every 3-4 weeks."
                        },
                        new
                        {
                            Id = 23,
                            Issues = "Overwatering.",
                            PlantName = "Doran Black Aloe",
                            Quantity = 0,
                            Sunlight = "Full sun to filtered/partial shade.",
                            Temperature = "40-80 degrees F.",
                            Water = "Once every 2-3 weeks."
                        },
                        new
                        {
                            Id = 24,
                            Issues = "Overwatering, spidermites, scale, or mealybugs.",
                            PlantName = "Ponytail Palm",
                            Quantity = 0,
                            Sunlight = "full sun or bright, indirect light.",
                            Temperature = "45-55 degrees F.",
                            Water = "Once every 3-4 weeks."
                        },
                        new
                        {
                            Id = 25,
                            Issues = "Fungal disease caused by overwatering.",
                            PlantName = "Bear's Paw",
                            Quantity = 0,
                            Sunlight = "Bright shaded areas.",
                            Temperature = "20-30 degrees F.",
                            Water = "Once a week."
                        },
                        new
                        {
                            Id = 26,
                            Issues = "Mealy bugs and scale.",
                            PlantName = "Tufted Ice Plant",
                            Quantity = 0,
                            Sunlight = "Full to partial sun.",
                            Temperature = "-20-40 degrees F.",
                            Water = "Once every 7-10 days."
                        },
                        new
                        {
                            Id = 27,
                            Issues = "Overwatering.",
                            PlantName = "Mexican Snowball",
                            Quantity = 0,
                            Sunlight = "At least 6 hours of direct full/partial sunlight.",
                            Temperature = "20-50 degrees F.",
                            Water = "Once every week; less in the winter."
                        },
                        new
                        {
                            Id = 28,
                            Issues = "Overwatering and sudden leaf wilting.",
                            PlantName = "Tigers Jaw Plant",
                            Quantity = 0,
                            Sunlight = "At least 3-4 hours of direct sunlight.",
                            Temperature = "70-90 degrees F.",
                            Water = "Once a weeks."
                        },
                        new
                        {
                            Id = 29,
                            Issues = "Root rot.",
                            PlantName = "Ghost Plant",
                            Quantity = 0,
                            Sunlight = "Full sun.",
                            Temperature = "12-112 degrees F.",
                            Water = "Once every 2-3 weeks."
                        },
                        new
                        {
                            Id = 30,
                            Issues = "Spider mites.",
                            PlantName = "Living Stone",
                            Quantity = 0,
                            Sunlight = "At least 4-5 hours of morning sunlight and partial shade in the afternoon.",
                            Temperature = "65-75 degrees F.",
                            Water = "Once every 2-3 weeks."
                        });
                });

            modelBuilder.Entity("Plant_Life.Models.DefaultPlantUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DefaultPlantId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantIndexViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DefaultPlantId");

                    b.HasIndex("PlantIndexViewModelId");

                    b.ToTable("DefaultPlantUser");
                });

            modelBuilder.Entity("Plant_Life.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Issues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantIndexViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Sunlight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Water")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PlantIndexViewModelId");

                    b.ToTable("Plant");
                });

            modelBuilder.Entity("Plant_Life.Models.PlantCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("PlantCalendar");
                });

            modelBuilder.Entity("Plant_Life.Models.ViewModel.PlantIndexViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("PlantIndexViewModel");
                });

            modelBuilder.Entity("Plant_Life.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d5c32cdc-9f64-46e1-b1fc-d966e133e61e",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJYlO1ByfXGO0XBJLQMuLC4YzfYyYJBRv9zQI4044UMhKB3ZCLFSiD8XrYYnNl0k7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com",
                            FirstName = "admin",
                            LastName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plant_Life.Models.Calendar", b =>
                {
                    b.HasOne("Plant_Life.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Plant_Life.Models.DefaultPlantUser", b =>
                {
                    b.HasOne("Plant_Life.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Plant_Life.Models.DefaultPlant", "DefaultPlant")
                        .WithMany()
                        .HasForeignKey("DefaultPlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plant_Life.Models.ViewModel.PlantIndexViewModel", null)
                        .WithMany("DefaultPlantUsers")
                        .HasForeignKey("PlantIndexViewModelId");
                });

            modelBuilder.Entity("Plant_Life.Models.Plant", b =>
                {
                    b.HasOne("Plant_Life.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Plant_Life.Models.ViewModel.PlantIndexViewModel", null)
                        .WithMany("Plants")
                        .HasForeignKey("PlantIndexViewModelId");
                });

            modelBuilder.Entity("Plant_Life.Models.PlantCalendar", b =>
                {
                    b.HasOne("Plant_Life.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
