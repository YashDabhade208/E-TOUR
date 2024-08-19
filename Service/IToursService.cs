using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface IToursService
    {

        Task<ActionResult<Tours>?> GetToursById(int id);
        Task<ActionResult<IEnumerable<Tours>>> GetAllTours();
        Task<ActionResult<Tours>> CreateTours(Tours tour);
        Task<ActionResult<Tours>> UpdateTours(int tour_id,Tours tour);
        Task<Tours>DeleteTours(int tour_id);

        Task<List<Tours>> GetToursBySubId(int subcategory_id);
    }
}
