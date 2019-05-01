using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
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
}
}
