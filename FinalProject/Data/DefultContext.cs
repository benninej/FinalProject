using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class DefultContext : DbContext
    {
        public DefultContext(DbContextOptions<DefultContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMembers>().HasData(
                new TeamMembers { FirstName = "Ellie", LastName = "Bennings", Brithday = "02/06/2004", Program = "Digital Media", Year = 4 },
                new TeamMembers { FirstName = "Noah", LastName = "Honsaker", Brithday = "00/00/0000", Program = "Computer Science", Year = 4 },
                new TeamMembers { FirstName = "Michael", LastName = "Johns", Brithday = "01/01/2000", Program = "Information Technology", Year = 3 });

        }
        public DbSet<TeamMembers> TeamMembers { get; set; }
    }
}
