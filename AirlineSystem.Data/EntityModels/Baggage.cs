using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSystem.Data.EntityModels
{
    public class Baggage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public BaggageType BaggageType { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BaggagePrice { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
