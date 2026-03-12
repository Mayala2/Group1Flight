using System;
using System.ComponentModel.DataAnnotations;

namespace Flights.Models
{
    public class Flight
    {
        
        public int FlightId { get; set; }

        [Required(ErrorMessage = "Please enter a city to Travel From")]
        public string From { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a city to Travel To")]
        public string To { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a date to Travel On")]
        [DataType(DataType.Date)]
        public DateTime? TravelDate { get; set; }

        [Required(ErrorMessage = "Please enter a price for the flight")]
        public string Price { get; set; } = string.Empty;

        
        public string Slug =>
            From?.Replace(' ', '-').ToLower() + '-' + TravelDate?.Year.ToString();
    }
}