using RoadRollerRide.Models;
using RoadRollerRide.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace RoadRollerRide.Services
{
    public class CarService
    {
        private readonly IAppDbContext _appDbContext;

        public CarService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Car> GetAll()
        {
            var cars = _appDbContext.Cars.ToList();

            return cars;
        }

        public List<Car> GetForGame()
        {
            var cars = _appDbContext.Cars.ToList();

            return cars;
        }
    }
}
