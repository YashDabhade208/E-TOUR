using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface IBookingService
    {
        Task<ActionResult<Booking>?> GetBookingById(int booking_id);
        Task<ActionResult<IEnumerable<Booking>>> GetAllBooking();
        Task<ActionResult<Booking>> CreateBooking(Booking booking);
        Task<ActionResult<Booking>> UpdateBooking(int booking_id, Booking booking);
        Task<Booking> DeleteBooking(int booking_id);

    }
}
