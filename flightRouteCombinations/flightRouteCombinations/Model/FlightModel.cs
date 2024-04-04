namespace flightRouteCombinations.Model
{
    public class FlightModel
    {
        public FlightModel()
        {
            TaxBreakDowns = new List<TaxBreakDown>();
        }
        public int Id { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public List<TaxBreakDown> TaxBreakDowns { get; set; }
    }
}
