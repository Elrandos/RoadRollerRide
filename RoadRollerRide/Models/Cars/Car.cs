using System;
using RoadRollerRide.Enums;
using RoadRollerRide.Enums.Cars;

namespace RoadRollerRide.Models.Cars
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarClassDirtRally Class { get; set; }
        public int HorsePower { get; set; }
        public int Weight { get; set; }
        public int Engine { get; set; }
        public int Cylinders { get; set; }
        public Transmission Transmission { get; set; }
        public int Year { get; set; }
        public Games Game { get; set; }
    }
}
