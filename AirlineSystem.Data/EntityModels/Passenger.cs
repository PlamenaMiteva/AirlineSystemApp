using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data.EntityModels
{
    public class Passenger
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DocumentType DocumentType { get; set; }

        [Required]
        public string DocumentNumber { get; set; }

        [Required]
        public DateTime DocumentExpireDate { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }

        public Guid ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
