using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Country
    {
        private ICollection<City> cities;
        private ICollection<Client> residents;

        public Country()
        {
            this.cities = new HashSet<City>();
            this.residents = new HashSet<Client>();
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

        public virtual ICollection<Client> Residents
        {
            get { return this.residents; }
            set { this.residents = value; }
        }
    }
}
