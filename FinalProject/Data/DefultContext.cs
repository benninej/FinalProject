using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class DefultContext : DbContext
    {
        public DefultContext(DbContextOptions<DefultContext> options) : base(options)
        {
        }

        public DbSet<TeamMembers> TeamMembers { get; set; }
    }
}
