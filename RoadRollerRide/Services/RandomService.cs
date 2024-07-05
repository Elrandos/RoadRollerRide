using System;
using System.Threading.Tasks;
using RoadRollerRide.Models;

namespace RoadRollerRide.Services
{
    public class RandomService
    {
        private readonly CarService _carService;
        private readonly MapService _mapService;
        public RandomService(CarService carService, MapService mapService)
        {
            _carService = carService;
            _mapService = mapService;
        }

        public Task<Car> GetRandomCarAsync()
        {
            var cars = _carService.GetAll();
            var random = new Random();
            var randomIndex = random.Next(0, cars.Count);

            return Task.FromResult(cars[randomIndex]);
        }

        public Task<Map> GetRandomMapAsync()
        {
            var maps = _mapService.GetAll();
            var random = new Random();
            var randomIndex = random.Next(0, maps.Count);

            return Task.FromResult(maps[randomIndex]);
        }
    }
}
