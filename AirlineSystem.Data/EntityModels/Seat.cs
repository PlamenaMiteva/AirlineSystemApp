using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSystem.Data.EntityModels
{
    public class Seat
    {        
        [Key]
        public Guid Id { get; set; }

        [Required]
        public SeatType SeatType { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SeatPrice { get; set; }

        [Required]
        public string SeatNumber { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
