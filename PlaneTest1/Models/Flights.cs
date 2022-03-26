using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTest1.Models
{
    public class Flights
    {
        [Key]
        public int PlaneNumber { get; set; }
        [Required(ErrorMessage = "Provide Date of arrival")]
        public DateTime Arrival { get; set; }
        [Required(ErrorMessage = "Provide Date of departure")]
        public DateTime Departure { get; set; }
        [Required(ErrorMessage = "Provide Pilot's name")]
        public string PilotName { get; set; }
        [Required(ErrorMessage = "Provide the location from where is the plane")]
        public string From { get; set; }
        [Required(ErrorMessage = "Provide the location to where is the plane headed")]
        public string To { get; set; }
        [Required(ErrorMessage = "Provide number of buisness class seats")]
        public int BuisnesSeats { get; set; }
        [Required(ErrorMessage = "Provide number of normal class seats")]
        public int NormalSeats { get; set; }
    }
}
