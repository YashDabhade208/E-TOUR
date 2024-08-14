using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface IPassengerService
    {
        Task<ActionResult<IEnumerable<Passenger>?>> GetAllPassenger();
        Task<ActionResult<Passenger>> GetPassengerById(int Passenger_id);
        Task<ActionResult<Passenger>> CreatePassenger(Passenger Passenger);
        Task<ActionResult<Passenger>> UpdatePassenger(int Passenger_id, Passenger Passenger);
        Task<ActionResult<Passenger>> DeletePassenger(int Passenger_id);
    }
}
