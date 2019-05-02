using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSystem.Data.EntityModels
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public TripType Trip { get; set; }

        [Required]
        public int PassengerNumber { get; set; }

        [Required]
        public Guid ClientId { get; set; }

        public virtual Client Client { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
