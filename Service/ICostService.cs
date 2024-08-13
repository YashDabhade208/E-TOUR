using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface ICostService
    {
        Task<ActionResult<IEnumerable<Cost>?>> GetAllCost();
        Task<ActionResult<Cost>> GetCostById(int cost_id);
        Task<ActionResult<Cost>> CreateCost(Cost cost);
        Task<ActionResult<Cost>> UpdateCost(int cost_id, Cost cost);
        Task<ActionResult<Cost>> DeleteCost(int cost_id);

    }
}
