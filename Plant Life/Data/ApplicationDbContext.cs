using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plant_Life.Models;
using Plant_Life.Models.ViewModel;

namespace Plant_Life.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<DefaultPlant> DefaultPlant { get; set; }
        public DbSet<DefaultPlantUser> DefaultPlantUser { get; set; }

        public DbSet<Plant> Plant { get; set; }
        public DbSet<PlantCalendar> PlantCalendar { get; set; }
        public DbSet<Event> Event { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create default plants 
            DefaultPlant defaultplant1 = new DefaultPlant
            {
                Id = 1,
                PlantName = "Aloe Vera",
                Sunlight = "Bright, indirect sunlight or artifical sunlight.",
                Temperature = "55-80 degrees F.",
                Water = "Once every 3-4 weeks.",
                Issues = "Diseases that occur with aloe vera is root rot, soft rot, fungal stem rot and leaf rot ",
                Quantity = 0

            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant1);

            DefaultPlant defaultplant2 = new DefaultPlant
            {
                Id = 2,
                PlantName = "Zebra Plant",
                Sunlight = "Partial sun or shade.",
                Temperature = "65-80 degrees F.",
                Water = "Once every 3-4 weeks.",
                Issues = "Usually pest free.",
                Quantity = 0

            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant2);

            DefaultPlant defaultplant3 = new DefaultPlant
            {
                Id = 3,
                PlantName = "Jade Plant",
                Sunlight = "Full sun for at least 4 hours each day.",
                Temperature = "65-70 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Black spots caused from insects, viruses, and fungal disease.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant3);

            DefaultPlant defaultplant4 = new DefaultPlant
            {
                Id = 4,
                PlantName = "Flaming Katy",
                Sunlight = "Bright light to full sun.",
                Temperature = "65-70 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Basal stem rot and Botryis.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant4);

            DefaultPlant defaultplant5 = new DefaultPlant
            {
                Id = 5,
                PlantName = "Burro's Tail",
                Sunlight = "Full sun for at least 4 hours each day.",
                Temperature = "65-75 degrees F.",
                Water = "Once every 4 weeks.",
                Issues = "Overwatering and Mealy bugs.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant5);

            DefaultPlant defaultplant6 = new DefaultPlant
            {
                Id = 6,
                PlantName = "Panda Plant",
                Sunlight = "Bright light to full sun.",
                Temperature = "60-75 degrees F.",
                Water = "Once every 10 days.",
                Issues = "Overwatering and Mealybugs, scale, red spidermites.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant6);

            DefaultPlant defaultplant7 = new DefaultPlant
            {
                Id = 7,
                PlantName = "Roseum",
                Sunlight = "Partial shade to full sun.",
                Temperature = "60-80 degrees F.",
                Water = "Once every 1-2 weeks.",
                Issues = "Mealybugs, scale, red spidermites, and overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant7);

            DefaultPlant defaultplant8 = new DefaultPlant
            {
                Id = 8,
                PlantName = "Pincushion Cactus",
                Sunlight = "Direct sunlight.",
                Temperature = "50-75 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Overwatering, Mealybugs, and scale bugs.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant8);

            DefaultPlant defaultplant9 = new DefaultPlant
            {
                Id = 9,
                PlantName = "Snake Plant",
                Sunlight = "low light, full light and indirect sunlight.",
                Temperature = "70-90 degrees F.",
                Water = "Once every 2-6 weeks.",
                Issues = "Fungal problems, such as southern blight and red leaf spot.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant9);

            DefaultPlant defaultplant10 = new DefaultPlant
            {
                Id = 10,
                PlantName = "Hens-and-Chicks",
                Sunlight = "Full sunlight.",
                Temperature = "65-75 degrees F.",
                Water = "Once a week.",
                Issues = "Overwatering causing root rot.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant10);

            DefaultPlant defaultplant11 = new DefaultPlant
            {
                Id = 11,
                PlantName = "Stonecrop",
                Sunlight = "Full sunlight.",
                Temperature = "-35-40 degrees F.",
                Water = "Once a week.",
                Issues = "Powdery mildrew, botrytis, and root rot.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant11);

            DefaultPlant defaultplant12 = new DefaultPlant
            {
                Id = 12,
                PlantName = "Whale's Tongue Agave",
                Sunlight = "Full sun or lightly filtered shade.",
                Temperature = "10-70 degrees F.",
                Water = "Once a week.",
                Issues = "none.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant12);

            DefaultPlant defaultplant13 = new DefaultPlant
            {
                Id = 13,
                PlantName = "Ball Cactus",
                Sunlight = "Direct sunlight in the morning/afternoonand partial shade during the hottest part of the day.",
                Temperature = "45-85 degrees F.",
                Water = "Once a week.",
                Issues = "Sucking pests, fungal and bacteria disease.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant13);

            DefaultPlant defaultplant14 = new DefaultPlant
            {
                Id = 14,
                PlantName = "Plush Plant",
                Sunlight = "Full to partial sun.",
                Temperature = "35-50 degrees F.",
                Water = "Once a week.",
                Issues = "Mealy bugs.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant14);

            DefaultPlant defaultplant15 = new DefaultPlant
            {
                Id = 15,
                PlantName = "Dudleya Plant",
                Sunlight = "Full sun and partial sun in afternoons.",
                Temperature = "18-50 degrees F.",
                Water = "Once a month.",
                Issues = "Ants, Mealy bugs, snails, slugs, and overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant15);

            DefaultPlant defaultplant16 = new DefaultPlant
            {
                Id = 16,
                PlantName = "Pig's Ear",
                Sunlight = "Full sun to partial shade.",
                Temperature = "18-22 degrees F.",
                Water = "1-2 times a month.",
                Issues = "Snails, slugs, and overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant16);

            DefaultPlant defaultplant17 = new DefaultPlant
            {
                Id = 17,
                PlantName = "Zwartkop Plant",
                Sunlight = "Full sun to partial shade.",
                Temperature = "65-75 degrees F.",
                Water = "Once every 10 days.",
                Issues = "Root rot caused by overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant17);

            DefaultPlant defaultplant18 = new DefaultPlant
            {
                Id = 18,
                PlantName = "Sunburst Plant",
                Sunlight = "Full sun for 6 hours at least.",
                Temperature = "40-100 degrees F.",
                Water = "1-2 times a month.",
                Issues = "Root rot from overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant18);

            DefaultPlant defaultplant19 = new DefaultPlant
            {
                Id = 19,
                PlantName = "Torch Cactus",
                Sunlight = "Bright sunlight for a minimum of four hours a day.",
                Temperature = "60-80 degrees F.",
                Water = "Once a month.",
                Issues = "Root rot and leaf rot from overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant19);

            DefaultPlant defaultplant20 = new DefaultPlant
            {
                Id = 20,
                PlantName = "Crown of Thorns",
                Sunlight = "At least 3-4 hours of direct full sunlight.",
                Temperature = "35-80 degrees F.",
                Water = "Once a week.",
                Issues = "Root rot caused by overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant20);

            DefaultPlant defaultplant21 = new DefaultPlant
            {
                Id = 21,
                PlantName = "Calico Hearts Plant",
                Sunlight = "At least 6 hours of direct full sunlight.",
                Temperature = "25-50 degrees F.",
                Water = "Once a week.",
                Issues = "Root rot caused by overwatering and toxic to humans and animals.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant21);

            DefaultPlant defaultplant22 = new DefaultPlant
            {
                Id = 22,
                PlantName = "Bunny Ears Cactus",
                Sunlight = "At least 4-5 hours of morning sunlight and partial shade in the afternoon.",
                Temperature = "45-100 degrees F.",
                Water = "Once every 3-4 weeks.",
                Issues = "Stem base rot and brown spots.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant22);

            DefaultPlant defaultplant23 = new DefaultPlant
            {
                Id = 23,
                PlantName = "Doran Black Aloe",
                Sunlight = "Full sun to filtered/partial shade.",
                Temperature = "40-80 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant23);

            DefaultPlant defaultplant24 = new DefaultPlant
            {
                Id = 24,
                PlantName = "Ponytail Palm",
                Sunlight = "full sun or bright, indirect light.",
                Temperature = "45-55 degrees F.",
                Water = "Once every 3-4 weeks.",
                Issues = "Overwatering, spidermites, scale, or mealybugs.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant24);

            DefaultPlant defaultplant25 = new DefaultPlant
            {
                Id = 25,
                PlantName = "Bear's Paw",
                Sunlight = "Bright shaded areas.",
                Temperature = "20-30 degrees F.",
                Water = "Once a week.",
                Issues = "Fungal disease caused by overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant25);

            DefaultPlant defaultplant26 = new DefaultPlant
            {
                Id = 26,
                PlantName = "Tufted Ice Plant",
                Sunlight = "Full to partial sun.",
                Temperature = "-20-40 degrees F.",
                Water = "Once every 7-10 days.",
                Issues = "Mealy bugs and scale.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant26);

            DefaultPlant defaultplant27 = new DefaultPlant
            {
                Id = 27,
                PlantName = "Mexican Snowball",
                Sunlight = "At least 6 hours of direct full/partial sunlight.",
                Temperature = "20-50 degrees F.",
                Water = "Once every week; less in the winter.",
                Issues = "Overwatering.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant27);

            DefaultPlant defaultplant28 = new DefaultPlant
            {
                Id = 28,
                PlantName = "Tigers Jaw Plant",
                Sunlight = "At least 3-4 hours of direct sunlight.",
                Temperature = "70-90 degrees F.",
                Water = "Once a weeks.",
                Issues = "Overwatering and sudden leaf wilting.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant28);

            DefaultPlant defaultplant29 = new DefaultPlant
            {
                Id = 29,
                PlantName = "Ghost Plant",
                Sunlight = "Full sun.",
                Temperature = "12-112 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Root rot.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant29);

            DefaultPlant defaultplant30 = new DefaultPlant
            {
                Id = 30,
                PlantName = "Living Stone",
                Sunlight = "At least 4-5 hours of morning sunlight and partial shade in the afternoon.",
                Temperature = "65-75 degrees F.",
                Water = "Once every 2-3 weeks.",
                Issues = "Spider mites.",
                Quantity = 0
            };
            modelBuilder.Entity<DefaultPlant>().HasData(defaultplant30);
        }


        public DbSet<Plant_Life.Models.ViewModel.PlantIndexViewModel> PlantIndexViewModel { get; set; }
    }
}
