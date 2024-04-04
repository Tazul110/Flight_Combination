namespace flightRouteCombinations.Model
{
    public class FlightByRoutes
    {
        public FlightByRoutes()
        {
            DirectionWiseFlight = new List<List<FlightModel>>();

            DirectionWiseFlight.Add(new List<FlightModel>()
        {
            new FlightModel
            {
                Id = 1,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Jashore",
                Destination = "Dhaka",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 2,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                 Origin = "Jashore",
                Destination = "Dhaka",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 3,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Jashore",
                Destination = "Dhaka",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            }
        });

            DirectionWiseFlight.Add(new List<FlightModel>()
        {
            new FlightModel
            {
                Id = 4,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Dhaka",
                Destination = "Chittagong",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 5,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Dhaka",
                Destination = "Chittagong",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 6,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Dhaka",
                Destination = "Chittagong",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            }
        });

            DirectionWiseFlight.Add(new List<FlightModel>()
        {
            new FlightModel
            {
                Id = 7,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Chittagong",
                Destination = "Rajshahi",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 8,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Chittagong",
                Destination = "Rajshahi",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            },
            new FlightModel
            {
                Id = 9,
                BasePrice = 100,
                TaxPrice = 10,
                TotalPrice = 110,
                Origin = "Chittagong",
                Destination = "Rajshahi",
                TaxBreakDowns = new List<TaxBreakDown>()
                {
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "VAT"
                    },
                    new TaxBreakDown
                    {
                        Tax = 5,
                        Description = "Service Charge"
                    }
                }
            }
        });
        }
        public List<List<FlightModel>> DirectionWiseFlight { get; set; }
    }
}

