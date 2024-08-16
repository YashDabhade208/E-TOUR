using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> CreateBooking(BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var booking = await service.CreateBooking(request);

            return CreatedAtAction(nameof(GetBookingById), new { id = booking.Value.Booking_Id }, booking);

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




    public class BookingRequest
    {
        public DateTime Booking_Date { get; set; }
        public int Customer_Id { get; set; }
        public int NoofChildWithBed { get; set; }

        public int NoofChildWithoutBed { get; set; }

        public int TotalPassengers { get; set; }
        public List<PassengerRequest> Passsengers { get; set; }
    }

    public class PassengerRequest
    {
        public string Passenger_Name { get; set; }
        public int Passenger_Age { get; set; }
        public string Passenger_MobNo { get; set; }
        public string Passenger_EmailId { get; set; }
        public string Passenger_Gender { get; set; }
        public string Passenger_Bed { get; set; }
    }

}

