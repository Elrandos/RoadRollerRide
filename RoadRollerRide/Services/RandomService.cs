using RoadRollerRide.Models.Cars;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RoadRollerRide.Interfaces.Services;
using RoadRollerRide.Models.Maps;

namespace RoadRollerRide.Services
{
    public class RandomService : IRandomService
    {
        public Task<Car> GetRandomCarAsync(List<Car> cars)
        {
            var random = new Random();
            var randomIndex = random.Next(0, cars.Count);

            return Task.FromResult(cars[randomIndex]);
        }

        public Task<Map> GetRandomMapAsync(List<Map> maps)
        {
            var random = new Random();
            var randomIndex = random.Next(0, maps.Count);

            return Task.FromResult(maps[randomIndex]);
        }
    }
}
