using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Baggage
    {
        private ICollection<Ticket> tickets;

        public Baggage()
        {
            this.tickets = new HashSet<Ticket>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public BaggageType BaggageType { get; set; }

        [Required]
        public decimal BaggagePrice { get; set; }

        public virtual ICollection<Ticket> Tickets
        {
            get { return this.tickets; }
            set { this.tickets = value; }
        }
    }
}
