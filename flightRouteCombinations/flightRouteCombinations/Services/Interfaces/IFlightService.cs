using flightRouteCombinations.Response;

namespace flightRouteCombinations.Services.Interfaces
{
    public interface IFlightService
    {
        public Task<List<FlightResponseModel>> GetAllFlights();
    }
}
