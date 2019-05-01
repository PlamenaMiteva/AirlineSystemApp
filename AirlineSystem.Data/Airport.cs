using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Airport
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string IataAirportCode { get; set; }
    }
}
