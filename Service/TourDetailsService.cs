using eTour.Model;

namespace eTour.Service
{
    public class TourDetailsService : ITourDetailsService
    {
        private readonly IToursService _tourService;
        private readonly IIterneryService _iterneryService;
        private readonly ICostService _costService;
        private readonly ITourDateService _tourDateService;

        public TourDetailsService(IToursService tourService, IIterneryService iterneryService, ICostService costService, ITourDateService tourDateService)
        {
            _tourService = tourService;
            _iterneryService = iterneryService;
            _costService = costService;
            _tourDateService = tourDateService;
        }
        public async Task<TourDetails> GetTourDetails(int Tour_Id)
        {
            var result = await _tourService.GetToursById(Tour_Id);
            var tour = result.Value;
            if (tour == null)
            {
                return null; 
            }

            var itineraries = await _iterneryService.GetIterneryByTourId(Tour_Id);
            var costDetails = await _costService.GetCostByTourId(Tour_Id);
            var availableDates = await _tourDateService.GetTourDatesByTourId(Tour_Id);

            return new TourDetails
            {
                Tour = tour,
                Itineraries = itineraries,
                CostDetails = costDetails,
                AvailableDates = availableDates
            };
        }
    }
}
