using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRollerRide.Models.Cars;
using RoadRollerRide.Models.Maps;

namespace RoadRollerRide.Models
{
    public class Database
    {
        public List<Car> Cars { get; set; }
        public List<Map> Maps { get; set; }

        public Database()
        {
            Cars = new List<Car>();
            Maps = new List<Map>();
        }
    }
}