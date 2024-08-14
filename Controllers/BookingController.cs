using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : Controller
    {
       

        private readonly IBookingService service;



        public BookingController(IBookingService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>?>> GetAllBooking()
        {
            return await service.GetAllBooking();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetBookingById(int Booking_id)
        {
            return await service.GetBookingById(Booking_id);
        }




        [HttpPost]
        public async Task<ActionResult<Booking>> CreateBooking(Booking Booking)
        {
            return await service.CreateBooking(Booking);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooking(int Booking_id, Booking Booking)
        {
            if (Booking_id != Booking.Booking_Id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateBooking(Booking_id, Booking);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Booking>> DeleteBooking(int Booking_id)
        {
            return await service.DeleteBooking(Booking_id);
        }
    }
}

