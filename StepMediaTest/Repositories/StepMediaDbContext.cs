using Microsoft.EntityFrameworkCore;
using StepMediaTest.Models;

namespace StepMediaTest.Repositories
{
    public class StepMediaDbContext : DbContext
    {
        public StepMediaDbContext(DbContextOptions<StepMediaDbContext> options) : base(options)
        {

        }

        public DbSet <Student> Students { get; set; }
        public DbSet <Teacher> Teachers { get; set; }
    }
}
