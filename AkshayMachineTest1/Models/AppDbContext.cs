using Microsoft.EntityFrameworkCore;

namespace AkshayMachineTest1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Information> Information { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<State> states { get; set; }
    }
}
