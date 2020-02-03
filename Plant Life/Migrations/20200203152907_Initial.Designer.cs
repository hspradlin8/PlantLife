﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plant_Life.Data;

namespace Plant_Life.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200203152907_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("PlantCare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DefaultPlant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlantCare = "Light: Bright, indirect sunlight or artifical sunlight. Temp:55-80 degrees F.Water:Once every 3-4 weeks.Issues:Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ",
                            PlantName = "Aloe Vera",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 2,
                            PlantCare = "Light:Partial sun or shade. Temp:65-80 degrees F.Water:Once every 3-4 weeks. Issues:Usually pest free.",
                            PlantName = "Zebra Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 3,
                            PlantCare = "Light:Full sun for at least 4 hours each day. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Black spots caused from insects, viruses, and fungal disease.",
                            PlantName = "Jade Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            PlantCare = "Light:Bright light to full sun. Temp:65-70 degrees F.Water:Once every 2-3 weeks.Issues:Basal stem rot and Botryis .",
                            PlantName = "Flaming Katy",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 5,
                            PlantCare = "Light:Full sun for at least 4 hours each day. Temp:65-75 degrees F.Water:Once every 4 weeks.Issues:Overwatering and Mealy bugs.",
                            PlantName = "Burro's Tail",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 6,
                            PlantCare = "Light:Bright light to full sun. Temp:60-75 degrees F.Water:Once every 10 days.Issues:Overwatering and Mealybugs, scale, red spidermites.",
                            PlantName = "Panda Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 7,
                            PlantCare = "Light:Partial shade to full sun. Temp:60-80 degrees F.Water:Once every 1-2 weeks.Issues:Mealybugs, scale, red spidermites, and overwatering.",
                            PlantName = "Roseum",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 8,
                            PlantCare = "Light:Direct sunlight. Temp:50-75 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering, Mealybugs, and scale bugs.",
                            PlantName = "Pincushion Cactus",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 9,
                            PlantCare = "Light:low light, full light and indirect sunlight. Temp:70-90 degrees F.Water:Once every 2-6 weeks.Issues:Fungal problems, such as southern blight and red leaf spot.",
                            PlantName = "Snake Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 10,
                            PlantCare = "Light:Full sunlight. Temp:65-75 degrees F.Water:Once a week.Issues:Overwatering causing root rot.",
                            PlantName = "Hens-and-Chicks",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 11,
                            PlantCare = "Light:Full sunlight. Temp:-35-40 degrees F.Water:Once a week.Issues:Powdery mildrew, botrytis, and root rot.",
                            PlantName = "Stonecrop",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 12,
                            PlantCare = "Light:Full sun or lightly filtered shade. Temp:10-70 degrees F.Water:Once a week.Issues:none.",
                            PlantName = "Whale's Tongue Agave",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 13,
                            PlantCare = "Light:Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.Temp:45-85 degrees F.Water:Once a week.Issues:Sucking pests, fungal and bacteria disease.",
                            PlantName = "Ball Cactus",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 14,
                            PlantCare = "Light: Full to partial sun.Temp:35-50 degrees F.Water:Once a week.Issues:Mealy bugs.",
                            PlantName = "Plush Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 15,
                            PlantCare = "Light: Full sun and partial sun in afternoons.Temp:18-50 degrees F.Water:Once a month.Issues:Ants, Mealy bugs, snails, slugs, and overwatering.",
                            PlantName = "Dudleya Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 16,
                            PlantCare = "Light: Full sun to partial shade.Temp:18-22 degrees F.Water:1-2 times a month.Issues:Snails, slugs, and overwatering.",
                            PlantName = "Pig's Ear",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 17,
                            PlantCare = "Light: Full sun to partial shade.Temp:65-75 degrees F.Water:Once every 10 days.Issues:Root rot caused by overwatering.",
                            PlantName = "Zwartkop Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 18,
                            PlantCare = "Light: Full sun for 6 hours at least.Temp:40-100 degrees F.Water:1-2 times a month.Issues:Root rot from overwatering.",
                            PlantName = "Sunburst Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 19,
                            PlantCare = "Light:Bright sunlight for a minimum of four hours a day.Temp:60-80 degrees F.Water:Once a month.Issues:Root rot and leaf rot from overwatering.",
                            PlantName = "Torch Cactus",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 20,
                            PlantCare = "Light:At least 3-4 hours of direct full sunlight.Temp:35-80 degrees F.Water:Once a week.Issues:Root rot caused by overwatering.",
                            PlantName = "Crown of Thorns",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 21,
                            PlantCare = "Light:At least 6 hours of direct full sunlight.Temp:25-50 degrees F.Water:Once a week.Issues:Root rot caused by overwatering and toxic to humans and animals.",
                            PlantName = "Calico Hearts Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 22,
                            PlantCare = "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:45-100 degrees F.Water:Once every 3-4 weeks.Issues:Stem base rot and brown spots.",
                            PlantName = "Bunny Ears Cactus",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 23,
                            PlantCare = "Light:Full sun to filtered/partial shade.Temp:40-80 degrees F.Water:Once every 2-3 weeks.Issues:Overwatering.",
                            PlantName = "Doran Black Aloe",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 24,
                            PlantCare = "full sun or bright, indirect light.Temp:45-55 degrees F.Water:Once every 3-4 weeks.Issues:overwatering, spidermites, scale, or mealybugs.",
                            PlantName = "Ponytail Palm",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 25,
                            PlantCare = "Light:Bright shaded areas.Temp:20-30 degrees F.Water:Once a week.Issues:Fungal disease caused by overwatering.",
                            PlantName = "Bear's Paw",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 26,
                            PlantCare = "Light: Full to partial sun.Temp:-20-40 degrees F.Water:Once every 7-10 days.Issues:Mealy bugs and scale.",
                            PlantName = "Tufted Ice Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 27,
                            PlantCare = "Light:At least 6 hours of direct full/partial sunlight.Temp:20-50 degrees F.Water:Once every week; less in the winter.Issues:Overwatering.",
                            PlantName = "Mexican Snowball",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 28,
                            PlantCare = "Light:At least 3-4 hours of direct sunlight.Temp:70-90 degrees F.Water:Once a weeks.Issues:Overwatering and sudden leaf wilting.",
                            PlantName = "Tigers Jaw Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 29,
                            PlantCare = "Light: Full sun.Temp: 12-112 degrees F.Water:Once every 2-3 weeks.Issues:Root rot.",
                            PlantName = "Ghost Plant",
                            Quantity = 0
                        },
                        new
                        {
                            Id = 30,
                            PlantCare = "Light:At least 4-5 hours of morning sunlight and partial shade in the afternoon.Temp:65-75 degrees F.Water:Once every 2-3 weeks.Issues:Spider mites.",
                            PlantName = "Living Stone",
                            Quantity = 0
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

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

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

                    b.Property<string>("PlantCare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

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
                            Id = "fb4ae189-eae3-495c-b5bb-8da37c817613",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db47527e-2604-4caa-94b0-be0f353d47a1",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHE73KzlVO7n9Vwzr1eY3OMFJ9JNw/7s9mKI0BYAUGMzgVRJzcjHEljLqfT4juKLzQ==",
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
                });

            modelBuilder.Entity("Plant_Life.Models.Plant", b =>
                {
                    b.HasOne("Plant_Life.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
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
