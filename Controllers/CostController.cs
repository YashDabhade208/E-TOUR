using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/cost")]
    [ApiController]
    public class CostController : Controller
    {
        private readonly ICostService service;

        public CostController(ICostService service) 
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cost>?>> GetAllCost()
        {
            return await service.GetAllCost();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cost>> GetCostByTourId(int cost_id)
        {
            return await service.GetCostByTourId(cost_id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cost>> UpdateCost(int cost_id,Cost cost)
        {
            return await service.UpdateCost(cost_id,cost);
        }

        [HttpPost]
        public async Task<ActionResult<Cost>> CreateCost(Cost cost)
        {
            return await service.CreateCost(cost);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cost>> DeleteCost(int cost_id)
        {
            return await service.DeleteCost(cost_id);
        }
    }
}
