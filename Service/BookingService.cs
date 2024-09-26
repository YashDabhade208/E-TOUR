using Azure.Core;
using eTour.Controllers;
using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class BookingService : IBookingService
    {
        private readonly Appdbcontext context;

        public BookingService(Appdbcontext context)
        {
            this.context = context;
        }

        [Authorize]
        public async  Task<ActionResult<Booking>> CreateBooking(BookingRequest request)
        {
            var booking = new Booking
            {
                Booking_Date = request.Booking_Date,
                NoofChildWithBed = request.NoofChildWithBed,
                NoofChildWithoutBed = request.NoofChildWithoutBed,
                TotalPassengers = request.TotalPassengers,
                Customer_Id = request.Customer_Id,
                Passsengers = request.Passsengers.Select(p => new Passenger
                {
                    Passenger_Name = p.Passenger_Name,
                    Passenger_Age = p.Passenger_Age,
                    Passenger_MobNo = p.Passenger_MobNo,
                    Passenger_EmailId = p.Passenger_EmailId,
                    Passenger_Gender = p.Passenger_Gender,
                    Passenger_Bed = p.Passenger_Bed
                }).ToList()
            };

            context.Bookings.Add(booking);
            await context.SaveChangesAsync();

            return booking;
        }

        public async Task<Booking> DeleteBooking(int booking_id)
        {
            Booking booking = context.Bookings.Find(booking_id);
            if (booking != null)
            {
                context.Bookings.Remove(booking);
                await context.SaveChangesAsync();
            }
            return booking;
        }

        public async Task<ActionResult<IEnumerable<Booking>>> GetAllBooking()
        {
            return await context.Bookings.ToListAsync();
        }

        public async  Task<ActionResult<Booking>?> GetBookingById(int booking_id)
        {
            var booking = await context.Bookings.FindAsync(booking_id);
            if (booking == null)
            {
                return null;
            }
            return booking;
        }

        public async  Task<ActionResult<Booking>> UpdateBooking(int booking_id, Booking booking)
        {

            if (booking_id != booking.Booking_Id)
            {
                return null;
            }

            context.Entry(booking).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return booking;
        }
    }

       

      
    }

