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
        }
    }
}
