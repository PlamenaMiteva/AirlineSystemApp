using AirlineSystem.Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AirlineSystem.Data.ContextData
{
    public class AirlineSystemContext : IdentityDbContext<IdentityUser>
    {
        public AirlineSystemContext(DbContextOptions<AirlineSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airorts { get; set; }
        public virtual DbSet<Baggage> Baggage { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=AirlineSystemDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
        .HasOne(da => da.DepartureAirport)
        .WithMany(f => f.InboundFlights)
        .HasForeignKey(da => da.DepartureAirportId)
        .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Flight>()
        .HasOne(aa => aa.ArrivalAirport)
        .WithMany(f => f.OutboundFlights)
        .HasForeignKey(aa => aa.ArrivalAirportId)
        .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
