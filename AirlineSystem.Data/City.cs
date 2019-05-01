using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class City
    {
        private ICollection<Airport> airports;

        public City()
        {
            this.airports = new HashSet<Airport>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Airport> Airports
        {
            get { return this.airports; }
            set { this.airports = value; }
        }
    }
}
