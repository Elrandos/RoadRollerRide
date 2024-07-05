using System;
using System.ComponentModel.DataAnnotations;
using RoadRollerRide.Enums;
using RoadRollerRide.Enums.Cars;

namespace RoadRollerRide.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public CarClassDirtRally Class { get; set; }
        public int HorsePower { get; set; }
        public int Weight { get; set; }
        public int Engine { get; set; }
        public int Cylinders { get; set; }
        public Transmission Transmission { get; set; }
        public int Year { get; set; }
    }
}
