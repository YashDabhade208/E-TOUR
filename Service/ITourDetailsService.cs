using eTour.Model;

namespace eTour.Service
{
    public interface ITourDetailsService
    {
        Task<TourDetails> GetTourDetails(int Tour_Id);
    }
}
