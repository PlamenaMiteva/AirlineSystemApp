using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

        [Required]
        public Guid BookingId { get; set; }

        public virtual Booking Booking { get; set; }

        [Required]
        public Guid FlightId { get; set; }

        public virtual Flight Flight { get; set; }

        [Required]
        public Guid SeatId { get; set; }

        public virtual Seat Seat { get; set; }

        [Required]
        public Guid BaggageId { get; set; }

        public virtual Baggage Baggage { get; set; }
    }
}
