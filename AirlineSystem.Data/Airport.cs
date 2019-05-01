using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Airport
    {
        private ICollection<Flight> inboundFlights;
        private ICollection<Flight> outboundFlights;

        public Airport()
        {
            this.inboundFlights = new HashSet<Flight>();
            this.outboundFlights = new HashSet<Flight>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string IataAirportCode { get; set; }

        [Required]
        public Guid CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Flight> InboundFlights
        {
            get { return this.inboundFlights; }
            set { this.inboundFlights = value; }
        }

        public virtual ICollection<Flight> OutboundFlights
        {
            get { return this.outboundFlights; }
            set { this.outboundFlights = value; }
        }
    }
}
