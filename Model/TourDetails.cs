namespace eTour.Model
{
    public class TourDetails
    {
        public Tours Tour { get; set; } 
        public IEnumerable<Iternery> Itineraries { get; set; } 
        public Cost CostDetails { get; set; } 
        public IEnumerable<TourDate> AvailableDates { get; set; }
    }
}
