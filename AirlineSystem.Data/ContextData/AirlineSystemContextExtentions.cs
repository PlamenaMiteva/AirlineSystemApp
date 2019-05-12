using AirlineSystem.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineSystem.Data.ContextData
{
    public static class AirlineSystemContextExtentions
    {
        public static void EnsureSeedDataForContext(this AirlineSystemContext context)
        {
            if (context.Flights.Any())
            {
                return;
            }

            var flights = new List<Flight>
            {
                new Flight
                {
                    DepartureAirport = new Airport{
                        Name = "Vrajdebna",
                        IataAirportCode = "SOF",
                        City = new City{
                            Name = "Sofia",
                            Country = new Country
                            {
                                Name = "Bulgaria"
                            }
                        }
                    },
                    ArrivalAirport = new Airport{
                    Name = "Malpensa",
                        IataAirportCode = "MXP",
                        City = new City{
                            Name = "Milano",
                            Country = new Country
                            {
                                Name = "Italy"
                            }
                        }},
                    DepartureTime_UTC =new DateTime(2019, 05, 02, 11, 15, 0),
                    ArrivalTime_UTC = new DateTime(2019, 05, 02, 13, 25, 0),
                    FlightPrice = 30
                },
                new Flight
                {
                    DepartureAirport = new Airport{
                        Name = "Barajas",
                        IataAirportCode = "MAD",
                        City = new City{
                            Name = "Madrid",
                            Country = new Country
                            {
                                Name = "Spain"
                            }
                        }
                    },
                    ArrivalAirport = new Airport{
                    Name = "Koeln-Bonn",
                        IataAirportCode = "CGN",
                        City = new City{
                            Name = "Cologne",
                            Country = new Country
                            {
                                Name = "Germany"
                            }
                        }},
                    DepartureTime_UTC =new DateTime(2019, 05, 02, 21, 05, 0),
                    ArrivalTime_UTC = new DateTime(2019, 05, 02, 23, 45, 0),
                    FlightPrice = 35
                },
                new Flight
                {
                    DepartureAirport = new Airport{
                        Name = "Beauvais",
                        IataAirportCode = "BVA",
                        City = new City{
                            Name = "Paris",
                            Country = new Country
                            {
                                Name = "France"
                            }
                        }
                    },
                    ArrivalAirport = new Airport{
                    Name = "Skavsta",
                        IataAirportCode = "NYO",
                        City = new City{
                            Name = "Stockholm",
                            Country = new Country
                            {
                                Name = "Sweden"
                            }
                        }},
                    DepartureTime_UTC =new DateTime(2019, 05, 02, 8, 05, 0),
                    ArrivalTime_UTC = new DateTime(2019, 05, 02, 10, 20, 0),
                    FlightPrice = 55
                }
            };

            //var italy = new Country { Name = "Italy" };
            //var spain = new Country { Name = "Spain" };
            //var bg = new Country { Name = "Bulgaria" };
            //var uk = new Country { Name = "UK" };
            //var germany = new Country { Name = "Germany" };
            //var france = new Country { Name = "France" };
            //context.Countries.AddRange(italy, spain, bg, uk, germany, france);

            context.Flights.AddRange(flights);

        }
    }
}
