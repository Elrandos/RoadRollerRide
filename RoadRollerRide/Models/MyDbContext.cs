using Microsoft.EntityFrameworkCore;
using RoadRollerRide.Models.Cars;

namespace RoadRollerRide.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(x => x.Id);
        }
    }
}
