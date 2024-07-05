using System.Data.Entity;
using System.Threading.Tasks;
using RoadRollerRide.Models;
using Database = System.Data.Entity.Database;

namespace RoadRollerRide.Persistence
{
    class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
