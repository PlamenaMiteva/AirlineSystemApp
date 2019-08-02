using AirlineSystem.Common;
using AirlineSystem.Data.EntityModels;
using System;
using System.Linq;

namespace AirlineSystem.Data.ContextData
{
    public static class AirlineSystemContextExtentions
    {
        public static void EnsureSeedDataForContext(this AirlineSystemContext context)
        {
            var italy = new Country { Name = "Italy" };
            var spain = new Country { Name = "Spain" };
            var bg = new Country { Name = "Bulgaria" };
            var uk = new Country { Name = "UK" };
            var germany = new Country { Name = "Germany" };
            var france = new Country { Name = "France" };
            if (!context.Countries.Any())
            {
                context.Countries.AddRange(italy, spain, bg, uk, germany, france);
                context.SaveChanges();
            }

            var sf = new City { Name = "Sofia", Country = bg };
            var rome = new City { Name = "Rome", Country = italy };
            var milan = new City { Name = "Milan", Country = italy };
            var madrid = new City { Name = "Madrid", Country = spain };
            var barcelona = new City { Name = "Barcelona", Country = spain };
            var london = new City { Name = "London", Country = uk };
            var berlin = new City { Name = "Berlin", Country = germany };
            var cologne = new City { Name = "Cologne", Country = germany };
            var hamburg = new City { Name = "Hamburg", Country = germany };
            var frankfurt = new City { Name = "Frankfurt", Country = germany };
            var paris = new City { Name = "Paris", Country = france };
            var nice = new City { Name = "Nice", Country = france };
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(sf, rome, milan, madrid, barcelona, london, berlin, cologne, hamburg, frankfurt, paris, nice);
                context.SaveChanges();
            }

            var sfAirport = new Airport { Name = "Vrajdebna", IataAirportCode = "SOF", City = sf };
            var fiumicino = new Airport { Name = "Fiumicino", IataAirportCode = "FCO", City = rome };
            var ciampino = new Airport { Name = "Ciampino", IataAirportCode = "CIA", City = rome };
            var malpensa = new Airport { Name = "Malpensa", IataAirportCode = "MXP", City = milan };
            var barajas = new Airport { Name = "Barajas", IataAirportCode = "MAD", City = madrid };
            var elprat = new Airport { Name = "El Prat", IataAirportCode = "BCN", City = barcelona };
            var heathrow = new Airport { Name = "Heathrow", IataAirportCode = "LHA", City = london };
            var gatwick = new Airport { Name = "Gatwick", IataAirportCode = "LGA", City = london };
            var luton = new Airport { Name = "Luton", IataAirportCode = "LTN", City = london };
            var tegel = new Airport { Name = "Tegel", IataAirportCode = "TXL", City = berlin };
            var cologneAirport = new Airport { Name = "Koeln-Bonn", IataAirportCode = "CGN", City = cologne };
            var hamburgAirport = new Airport { Name = "Hamburg", IataAirportCode = "HAM", City = hamburg };
            var frankfurtAirport = new Airport { Name = "Frankfurt/Main", IataAirportCode = "FRA", City = frankfurt };
            var beauvais = new Airport { Name = "Beauvais", IataAirportCode = "BVA", City = paris };
            var orly = new Airport { Name = "Orly", IataAirportCode = "ORY", City = paris };
            var charlesDeGaulle = new Airport { Name = "Charles de Gaulle", IataAirportCode = "CDG", City = paris };
            var niceAirport = new Airport { Name = "Côte d'Azur", IataAirportCode = "NCE", City = nice };
            if (!context.Airorts.Any())
            {
                context.Airorts.AddRange(sfAirport, fiumicino, ciampino, malpensa, barajas, elprat, heathrow, gatwick, luton, tegel, cologneAirport, hamburgAirport, frankfurtAirport, beauvais, orly, charlesDeGaulle, niceAirport);
                context.SaveChanges();
            }

            if (!context.Flights.Any())
            {
                var startDate = new DateTime(2019, 07, 01);
                var endDate = new DateTime(2019, 12, 31);
                var mondays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Monday);
                var tuesdays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Tuesday);
                var wednesdays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Wednesday);
                var thursdays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Thursday);
                var fridays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Friday);
                var saturdays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Saturday);
                var sundays = DateTimeUtils.GetDatesByDayOfWeek(startDate, endDate, DayOfWeek.Sunday);

                foreach (var date in mondays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = beauvais,
                        ArrivalAirport = hamburgAirport,
                        FlightPrice = 55,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 8, 05, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 20, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = hamburgAirport,
                        ArrivalAirport = beauvais,
                        FlightPrice = 55,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 20, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 14, 40, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = charlesDeGaulle,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 60,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 6, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 7, 30, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = charlesDeGaulle,
                        FlightPrice = 60,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 8, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 30, 0)
                    };
                    var outboundFlight_3 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = heathrow,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 40, 0)
                    };
                    var inboundFlight_3 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 40, 0)
                    };
                    var outboundFlight_4 = new Flight
                    {
                        DepartureAirport = charlesDeGaulle,
                        ArrivalAirport = heathrow,
                        FlightPrice = 54,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 16, 35, 0)
                    };
                    var inboundFlight_4 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = charlesDeGaulle,
                        FlightPrice = 54,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 17, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 18, 35, 0)
                    };
                    var outboundFlight_5 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 26, 0)
                    };
                    var inboundFlight_5 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 26, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);
                    context.Flights.Add(outboundFlight_3);
                    context.Flights.Add(inboundFlight_3);
                    context.Flights.Add(outboundFlight_4);
                    context.Flights.Add(inboundFlight_4);
                    context.Flights.Add(outboundFlight_5);
                    context.Flights.Add(inboundFlight_5);
                }

                foreach (var date in tuesdays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = sfAirport,
                        ArrivalAirport = malpensa,
                        FlightPrice = 30,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 25, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = malpensa,
                        ArrivalAirport = sfAirport,
                        FlightPrice = 30,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 25, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 17, 30, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 40, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 36, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 40, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 36, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);
                }

                foreach (var date in wednesdays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = barajas,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 35,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 05, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 45, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = barajas,
                        FlightPrice = 35,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 45, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 16, 25, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = heathrow,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 40, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 40, 0)
                    };
                    var outboundFlight_3 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 26, 0)
                    };
                    var inboundFlight_3 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 26, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);
                    context.Flights.Add(outboundFlight_3);
                    context.Flights.Add(inboundFlight_3);
                }

                foreach (var date in thursdays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = sfAirport,
                        ArrivalAirport = malpensa,
                        FlightPrice = 30,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 18, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 20, 40, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = malpensa,
                        ArrivalAirport = sfAirport,
                        FlightPrice = 30,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 21, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 23, 35, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = heathrow,
                        FlightPrice = 23,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 05, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 23,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 05, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);
                }

                foreach (var date in fridays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = charlesDeGaulle,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 60,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 9, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 30, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = charlesDeGaulle,
                        FlightPrice = 60,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 30, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = heathrow,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 14, 10, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 88,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 16, 35, 0)
                    };
                    var outboundFlight_3 = new Flight
                    {
                        DepartureAirport = charlesDeGaulle,
                        ArrivalAirport = heathrow,
                        FlightPrice = 54,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 11, 35, 0)
                    };
                    var inboundFlight_3 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = charlesDeGaulle,
                        FlightPrice = 54,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 15, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 35, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);
                    context.Flights.Add(outboundFlight_3);
                    context.Flights.Add(inboundFlight_3);
                }

                foreach (var date in saturdays)
                {
                    var outboundFlight = new Flight
                    {
                        DepartureAirport = frankfurtAirport,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 26, 0)
                    };
                    var inboundFlight = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = frankfurtAirport,
                        FlightPrice = 18,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 14, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 26, 0)
                    };
                    context.Flights.Add(outboundFlight);
                    context.Flights.Add(inboundFlight);
                }

                foreach (var date in sundays)
                {
                    var outboundFlight_1 = new Flight
                    {
                        DepartureAirport = barajas,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 35,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 10, 00, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 12, 50, 0)
                    };
                    var inboundFlight_1 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = barajas,
                        FlightPrice = 35,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 50, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 16, 30, 0)
                    };
                    var outboundFlight_2 = new Flight
                    {
                        DepartureAirport = cologneAirport,
                        ArrivalAirport = heathrow,
                        FlightPrice = 23,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 13, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 15, 05, 0)
                    };
                    var inboundFlight_2 = new Flight
                    {
                        DepartureAirport = heathrow,
                        ArrivalAirport = cologneAirport,
                        FlightPrice = 23,
                        DepartureTime_UTC = new DateTime(date.Year, date.Month, date.Day, 16, 30, 0),
                        ArrivalTime_UTC = new DateTime(date.Year, date.Month, date.Day, 17, 05, 0)
                    };
                    context.Flights.Add(outboundFlight_1);
                    context.Flights.Add(inboundFlight_1);
                    context.Flights.Add(outboundFlight_2);
                    context.Flights.Add(inboundFlight_2);

                }

                context.SaveChanges();
            }
        }
    }
}
