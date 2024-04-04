using flightRouteCombinations.Model;

namespace flightRouteCombinations.Response
{
    public class FlightResponseModel
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal TotalTaxPrice { get; set; }
        public List<FlightDetails> Flights { get; set; }
        public List<TaxBreakDown> TaxBreakDowns { get; set; }
    }
}
