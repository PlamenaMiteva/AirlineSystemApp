using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data.EntityModels
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Airport> Airports { get; set; } = new HashSet<Airport>();
    }
}
