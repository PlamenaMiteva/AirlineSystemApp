using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Seat
    {
        private ICollection<Ticket> tickets;

        public Seat()
        {
            this.tickets = new HashSet<Ticket>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public SeatType SeatType { get; set; }

        [Required]
        public decimal SeatPrice { get; set; }

        [Required]
        public string SeatNumber { get; set; }

        public virtual ICollection<Ticket> Tickets
        {
            get { return this.tickets; }
            set { this.tickets = value; }
        }
    }
}
