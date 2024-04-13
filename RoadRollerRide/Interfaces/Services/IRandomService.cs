using RoadRollerRide.Models.Cars;
using RoadRollerRide.Models.Maps;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadRollerRide.Interfaces.Services
{
    public interface IRandomService
    {
        Task<Car> GetRandomCarAsync(List<Car> cars);
        Task<Map> GetRandomMapAsync(List<Map> maps);
    }
}
