namespace flightRouteCombinations.Model
{
    public class FlightDetails
    {
        public int Id { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
