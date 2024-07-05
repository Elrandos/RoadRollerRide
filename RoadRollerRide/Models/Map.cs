using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRollerRide.Enums;

namespace RoadRollerRide.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
