using flightRouteCombinations.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flightRouteCombinations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightCombinationController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightCombinationController(IFlightService flightService)
        {
            _flightService = flightService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFlights()
        {
            var flights = await _flightService.GetAllFlights();
            return Ok(flights);
        }
    }
}
