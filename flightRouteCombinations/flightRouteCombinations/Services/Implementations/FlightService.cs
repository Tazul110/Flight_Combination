using flightRouteCombinations.Model;
using flightRouteCombinations.Response;
using flightRouteCombinations.Services.Interfaces;

namespace flightRouteCombinations.Services.Implementations
{
    public class FlightService : IFlightService
    {
        private readonly FlightByRoutes _flightByRoutes;
        public FlightService()
        {
            _flightByRoutes = new FlightByRoutes();
        }

        public async Task<List<FlightResponseModel>> GetAllFlights()
        {
            var flights = new List<FlightResponseModel>();

            var allPossibleCombinations = GetAllCombinations(_flightByRoutes.DirectionWiseFlight);

            foreach (var comb in allPossibleCombinations)
            {
                decimal totalPrice = 0;
                decimal totalBasePrice = 0;
                decimal totalTaxPrice = 0;
                List< TaxBreakDown > taxBreakdowns = new List< TaxBreakDown >();
                foreach (var i in comb)
                {
                    totalPrice += i.TotalPrice;
                    totalBasePrice += i.BasePrice;
                    totalTaxPrice += i.TaxPrice;
                    taxBreakdowns.AddRange(i.TaxBreakDowns);
                }
                /*var totalPrice = comb.Sum(onFlight => onFlight.TotalPrice);
                var totalBasePrice = comb.Sum(onFlight => onFlight.BasePrice);
                var totalTaxPrice = comb.Sum(onFlight => onFlight.TaxPrice);
                var taxBreakdowns = comb.SelectMany(onFlight => onFlight.TaxBreakDowns).ToList();*/

                var flightDetails = comb.Select(onFlight => new FlightDetails
                {
                    Id = onFlight.Id,
                    BasePrice = onFlight.BasePrice,
                    TaxPrice = onFlight.TaxPrice,
                    TotalPrice = onFlight.TotalPrice,
                    Origin = onFlight.Origin,
                    Destination = onFlight.Destination
                }).ToList();

                var flightResponse = new FlightResponseModel
                {
                    TotalPrice = totalPrice,
                    TotalBasePrice = totalBasePrice,
                    TotalTaxPrice = totalTaxPrice,
                    Flights = flightDetails,
                    TaxBreakDowns = taxBreakdowns,
                };

                flights.Add(flightResponse);
            }
            Console.WriteLine(flights.Count);
            return flights;
        }

        private List<List<FlightModel>> GetAllCombinations(List<List<FlightModel>> directionWiseFlights)
        {
            var totalCombinations = new List<List<FlightModel>>();

            GenerateCombinations(directionWiseFlights, totalCombinations, new List<FlightModel>(), 0);

            return totalCombinations;
        }

        private void GenerateCombinations(List<List<FlightModel>> directionWiseFlights, List<List<FlightModel>> totalCombinations, List<FlightModel> currentCombination, int cur_id)
        {
            var cnt = directionWiseFlights.Count;
            
            if (cur_id == cnt)
            {    
                totalCombinations.Add(new List<FlightModel>(currentCombination));
                return;
            }

            foreach (var flight in directionWiseFlights[cur_id])
            {
                currentCombination.Add(flight);
                GenerateCombinations(directionWiseFlights, totalCombinations, currentCombination, cur_id + 1);
                cnt = currentCombination.Count;
                currentCombination.RemoveAt(cnt - 1);
            }
        }
    }
}
