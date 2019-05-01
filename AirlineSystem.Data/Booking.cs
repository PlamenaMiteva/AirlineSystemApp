using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Booking
    {
        private ICollection<Ticket> departureFlightTickets;
        private ICollection<Ticket> arrivalFlightTickets;

        public Booking()
        {
            this.departureFlightTickets = new HashSet<Ticket>();
            this.arrivalFlightTickets = new HashSet<Ticket>();
        }

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
        public decimal Price { get; set; }

        public virtual ICollection<Ticket> DepartureFlightTickets
        {
            get { return this.departureFlightTickets; }
            set { this.departureFlightTickets = value; }
        }

        public virtual ICollection<Ticket> ArrivalFlightTickets
        {
            get { return this.arrivalFlightTickets; }
            set { this.arrivalFlightTickets = value; }
        }
    }
}
