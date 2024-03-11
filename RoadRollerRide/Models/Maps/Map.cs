using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRollerRide.Enums;

namespace RoadRollerRide.Models.Maps
{
    public class Map
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Games Game { get; set; }
    }
}
