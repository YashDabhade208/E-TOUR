using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/passenger")]
    [ApiController]
    public class PassengerController : Controller
    {
        private readonly IPassengerService service;

        public PassengerController(IPassengerService service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passenger>?>> GetAllPassenger()
        {
            return await service.GetAllPassenger();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Passenger>> GetPassengerById(int Passenger_id)
        {
            return await service.GetPassengerById(Passenger_id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Passenger>> UpdatePassenger(int Passenger_id, Passenger passenger)
        {
            return await service.UpdatePassenger(Passenger_id, passenger);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Passenger>> DeletePassenger(int Passenger_id)
        {
            return await service.DeletePassenger(Passenger_id);
        }

        [HttpPost]
        public async Task<ActionResult<Passenger>> CreatePassenger(Passenger passenger)
        {
            return await service.CreatePassenger(passenger);
        }
    }
}
