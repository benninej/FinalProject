using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class DefultContext : DbContext
    {
        public DefultContext(DbContextOptions<DefultContext> options) : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Menu> MenuItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    Id = 1,
                    FullName = "Noah Honsaker",
                    Birthdate = new DateTime(2000, 1, 2),
                    CollegeProgram = "IT",
                    YearInProgram = "Sophmore"
                },
                new TeamMember
                {
                    Id = 2,
                    FullName = "Ellie Bennings",
                    Birthdate = new DateTime(2001, 3, 4),
                    CollegeProgram = "Digital Media",
                    YearInProgram = "Sophmore"
                },
                new TeamMember
                {
                    Id = 3,
                    FullName = "Micheal Jones",
                    Birthdate = new DateTime(2000, 5, 6),
                    CollegeProgram = "IT",
                    YearInProgram = "Sophmore"
                }
            );

            modelBuilder.Entity<Menu>().HasData(
            new Menu
            {
            FoodId = 1,
            Name = "Margherita Pizza",
            Price = 12.99m,
            Category = "Main Course",
            IsVegetarian = true
            },
             new Menu
             {
                FoodId = 2,
                Name = "Caesar Salad",
                Price = 8.50m,
                Category = "Starters",
                IsVegetarian = true
             },
             new Menu
             {
             FoodId = 3,
             Name = "Beef Burger",
             Price = 10.00m,
             Category = "Main Course",
             IsVegetarian = false
             },
             new Menu
            {
             FoodId = 4,
             Name = "Chocolate Lava Cake",
             Price = 6.00m,
             Category = "Desserts",
             IsVegetarian = true
             }
);

            modelBuilder.Entity<Sports>().HasData(
               new Sports
               {
                   Id = 1,
                   Name = "Noah Honsaker",
                   Sport = "Football",
                   Team = "Bengals",
                   Wins = "6"
               },
               new Sports
               {
                   Id = 2,
                   Name = "Ellie Bennings",
                   Sport = "Volleyball",
                   Team = "Japan Mens National",
                   Wins = "9"
               },
               new Sports
               {
                   Id = 3,
                   Name = "Micheal Jones",
                   Sport = "Swimming",
                   Team = "US National Team",
                   Wins = "9"
               }
           );

            modelBuilder.Entity<Favorites>().HasData(
                new Favorites
                {
                    Id = 1,
                    Name = "Noah Honsaker",
                    Food = "Hamburger",
                    Music = "Indie",
                    Hobby = "Hiking",
                    Animal = "Cat"
                },
                new Favorites
                {
                    Id = 2,
                    Name = "Ellie Bennings",
                    Food = "Pasta",
                    Music = "Kpop",
                    Hobby = "Drawing",
                    Animal = "Bunny"
                },
                new Favorites
                {
                    Id = 3,
                    Name = "Michael Jones",
                    Food = "General Tso's Chicken",
                    Music = "Techno",
                    Hobby = "Video Games",
                    Animal = "Snake"
                }
           );
        }
    }
}
