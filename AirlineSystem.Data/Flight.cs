using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public City DepartureCity { get; set; }

        [Required]
        public City ArrivalCity { get; set; }

        [Required]
        public DateTime DepartureTime_UTC { get; set; }

        [Required]
        public DateTime ArrivalTime_UTC { get; set; }
    }
}
