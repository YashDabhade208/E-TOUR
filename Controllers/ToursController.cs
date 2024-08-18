using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/tours")]
    [ApiController]
    public class ToursController : Controller
    {

        private readonly IToursService service;
        private readonly ICostService _costService;
        private readonly ITourDateService _tourDateService;
        private readonly IIterneryService _iterneryService;
        private readonly ITourDetailsService _tourDetailsService;

        public ToursController(
            IToursService tourService,
            ICostService costService,
            ITourDateService tourDateService,
            IIterneryService iterneryService,
            ITourDetailsService tourDetailsService)
        {
            service = tourService;
            _costService = costService;
            _tourDateService = tourDateService;
            _iterneryService = iterneryService;
            _tourDetailsService = tourDetailsService;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tours>?>> GetAllTours()
        {
            return await service.GetAllTours();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Tours>> GetToursById(int tour_id)
        {
            return await service.GetToursById(tour_id);
        }

        [HttpPost]
        public async Task<ActionResult<Tours>> CreateTours(Tours tour)
        {
            return await service.CreateTours(tour);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int tour_id, Tours tour)
        {
            if (tour_id != tour.Tour_Id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateTours(tour_id, tour);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tours>> DeleteSubCategory(int tour_id)
        {
            return await service.DeleteTours(tour_id);
        }















        [HttpGet("details/{id}")]
        public async Task<ActionResult<TourDetails>> GetTourDetails(int id)
        {
            var tourDetails = await _tourDetailsService.GetTourDetails(id);

            if (tourDetails == null)
            {
                return NotFound();
            }

            return Ok(tourDetails);
        }

    }

}

