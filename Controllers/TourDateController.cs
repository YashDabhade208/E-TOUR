using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/tourdate")]
    [ApiController]
    public class TourDateController : Controller
    {
       private readonly ITourDateService service;
        public TourDateController(ITourDateService service) 
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourDate>?>> GetAllTourDate()
        {
            return await service.GetAllTourDate();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TourDate>> GetTourDateById(int tourdate_id)
        {
            return await service.GetTourDateById(tourdate_id);
        }

        [HttpPost]
        public async Task<ActionResult<TourDate>> CreateTourDate(TourDate tourdate)
        {
            return await service.CreateTourDate(tourdate);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TourDate>> UpdateTourData(int tourdate_id,TourDate tourdate)
        {
            return await service.UpdateDate(tourdate_id, tourdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TourDate>> DeleteTourDate(int tourdate_id)
        {
            return await service.DeleteDate(tourdate_id);
        }

       
    }
}
