using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSystem.Data.EntityModels
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }

        public Guid DepartureAirportId { get; set; }

        public virtual Airport DepartureAirport { get; set; }
        
        public Guid ArrivalAirportId { get; set; }

        public virtual Airport ArrivalAirport { get; set; }

        [Required]
        public DateTime DepartureTime_UTC { get; set; }

        [Required]
        public DateTime ArrivalTime_UTC { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FlightPrice { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
