using System.Collections.Generic;
using RoadRollerRide.Models;
using RoadRollerRide.Persistence;
using System.Linq;

namespace RoadRollerRide.Services
{
    public class MapService
    {
        private readonly IAppDbContext _appDbContext;

        public MapService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Map> GetAll()
        {
            var cars = _appDbContext.Maps.ToList();

            return cars;
        }
    }
}
