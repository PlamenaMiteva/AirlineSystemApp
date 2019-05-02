using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSystem.Data.EntityModels
{
    public class Airport
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string IataAirportCode { get; set; }

        [Required]
        public Guid CityId { get; set; }

        public virtual City City { get; set; }

        [InverseProperty("DepartureAirport")]
        public virtual ICollection<Flight> InboundFlights { get; set; } = new HashSet<Flight>();

        [InverseProperty("ArrivalAirport")]
        public virtual ICollection<Flight> OutboundFlights { get; set; } = new HashSet<Flight>();
    }
}
