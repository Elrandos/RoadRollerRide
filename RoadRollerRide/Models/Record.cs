using System;
using System.ComponentModel.DataAnnotations;

namespace RoadRollerRide.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Map Map { get; set; }
        [Required]
        public Car Car { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
    }
}
