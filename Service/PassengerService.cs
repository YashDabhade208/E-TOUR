using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class PassengerService : IPassengerService
    {
        private readonly Appdbcontext contex;

        public PassengerService(Appdbcontext contex)
        {
            this.contex = contex;
        }
        public async Task<ActionResult<Passenger>> CreatePassenger(Passenger passenger)
        {
            contex.Passengers.Add(passenger);
            await contex.SaveChangesAsync();
            return passenger;
        }

        public async Task<ActionResult<Passenger>> DeletePassenger(int passenger_id)
        {
            Passenger passenger = contex.Passengers.Find(passenger_id);
            if (passenger != null)
            {
                contex.Passengers.Remove(passenger);
                await contex.SaveChangesAsync();
            }
            return passenger;
        }

        public async Task<ActionResult<IEnumerable<Passenger>?>> GetAllPassenger()
        {
            if (contex.Passengers == null)
            {
                return null;
            }
            return await contex.Passengers.ToListAsync();
        }

        public async Task<ActionResult<Passenger>> GetPassengerById(int passenger_id)
        {
            if (contex.Passengers == null)
            {
                return null;
            }
            var passenger = await contex.Passengers.FindAsync(passenger_id);
            if (passenger == null)
            {
                return null;
            }
            return passenger;
        }

        public async Task<ActionResult<Passenger>> UpdatePassenger(int passenger_id, Passenger passenger)
        {
            if (passenger_id != passenger.Passenger_Id)
            {
                return null;
            }

            contex.Entry(passenger).State = EntityState.Modified;

            try
            {
                await contex.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return passenger;
        }
    }
}
