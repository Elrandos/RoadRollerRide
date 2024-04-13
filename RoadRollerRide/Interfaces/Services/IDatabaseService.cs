using RoadRollerRide.Models;
using RoadRollerRide.Models.Cars;
using RoadRollerRide.Models.Maps;
using System.Collections.Generic;
using System.Linq;

namespace RoadRollerRide.Interfaces.Services
{
    public interface IDatabaseService
    {
        Database LoadDatabase();
        void SaveDatabase(Database database);
        List<Car> GetAllCarsForDirtRally(Database database);
        List<Map> GetAllMapsForDirtRally(Database database);
    }
}
