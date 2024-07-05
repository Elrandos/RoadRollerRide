using RoadRollerRide.Models;
using RoadRollerRide.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using System.Threading.Tasks;
using RoadRollerRide.Enums.Cars;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;

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

        public async Task<Car> AddCar(string brand, string model, int carDirtRallyClass, int horsePower, int weight, int engine, int cylinders, int transmission, int year)
        {
            if (!Enum.IsDefined(typeof(CarClassDirtRally), carDirtRallyClass))
            {
                throw new ArgumentException("Invalid category value", nameof(carDirtRallyClass));
            }
            if (!Enum.IsDefined(typeof(Transmission), transmission))
            {
                throw new ArgumentException("Invalid category value", nameof(transmission));
            }

            var car = new Car()
            {
                Brand = brand,
                Model = model,
                Class = (CarClassDirtRally)carDirtRallyClass,
                HorsePower = horsePower,
                Weight = weight,
                Engine = engine,
                Cylinders = cylinders,
                Transmission = (Transmission)transmission,
                Year = year
            };

            var result = _appDbContext.Cars.Add(car);
            await _appDbContext.SaveChangesAsync();
            return result;
        }
    }
}
