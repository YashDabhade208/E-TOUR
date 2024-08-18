using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class CostService : ICostService
    {
        private readonly Appdbcontext contex;

        public CostService(Appdbcontext contex)
        {
            this.contex = contex;
        }

        public async Task<ActionResult<Cost>> DeleteCost(int cost_id)
        {
            Cost cost=contex.Costs.Find(cost_id);
            if(cost != null)
            {
                contex.Costs.Remove(cost);
                await contex.SaveChangesAsync();
            }
            return cost;
        }

        public async Task<ActionResult<IEnumerable<Cost>?>> GetAllCost()
        {
            return await contex.Costs.ToListAsync();
        }

        public async Task<ActionResult<Cost>> CreateCost(Cost cost)
        {
            contex.Costs.Add(cost);
            await contex.SaveChangesAsync();
            return cost;
        }

        public async Task<ActionResult<Cost>> GetCostById(int cost_id)
        {
            var cost = await contex.Costs.FindAsync(cost_id);
            if(cost != null) 
            {
                return cost;
            }
            return null;    
        }

        public async Task<ActionResult<Cost>> UpdateCost(int cost_id, Cost cost)
        {
            contex.Entry(cost).State = EntityState.Modified;
            try
            {
                await contex.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return cost;
        }

        public async Task<Cost> GetCostByTourId(int Tour_Id)
        {
            return await contex.Costs
                 .FirstOrDefaultAsync(c => c.Tour_Id == Tour_Id);
        }
    }
}
