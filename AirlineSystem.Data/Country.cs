using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Country
    {
        private ICollection<City> cities;

        public Country()
        {
            this.cities = new HashSet<City>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<City> Cities
        {
            get { return this.cities; }
            set { this.cities = value; }
        }
    }
}
