using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data.EntityModels
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();

        public virtual ICollection<Client> Residents { get; set; } = new HashSet<Client>();
    }
}
