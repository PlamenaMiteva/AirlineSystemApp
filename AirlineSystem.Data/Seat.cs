using System;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public SeatType SeatType { get; set; }

        [Required]
        public string SeatNumber { get; set; }
    }
}
