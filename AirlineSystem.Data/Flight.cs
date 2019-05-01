﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Flight
    {
        private ICollection<Ticket> tickets;

        public Flight()
        {
            this.tickets = new HashSet<Ticket>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid DepartureCityId { get; set; }

        public City DepartureCity { get; set; }

        [Required]
        public Guid ArrivalCityId { get; set; }

        public City ArrivalCity { get; set; }

        [Required]
        public DateTime DepartureTime_UTC { get; set; }

        [Required]
        public DateTime ArrivalTime_UTC { get; set; }

        [Required]
        public decimal FlightPrice { get; set; }

        public virtual ICollection<Ticket> Tickets
        {
            get { return this.tickets; }
            set { this.tickets = value; }
        }
    }
}
