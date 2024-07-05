using System.Data.Entity;
using System.Threading.Tasks;
using RoadRollerRide.Models;

namespace RoadRollerRide.Persistence
{
    public interface IAppDbContext
    {
        DbSet<Car> Cars { get; set; } 
        DbSet<Map> Maps { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync();

    }
}
