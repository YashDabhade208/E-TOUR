using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class IterneryService : IIterneryService
    {

        private readonly Appdbcontext contex;

        public IterneryService(Appdbcontext contex)
        {
            this.contex = contex;
        }

        public async Task<ActionResult<Iternery>> CreateIternery(Iternery iternery)
        {
            contex.Iterneries.Add(iternery);
            await contex.SaveChangesAsync();
            return iternery;
        }

        public async Task<Iternery> DeleteIternery(int iternery_id)
        {
            Iternery iternery = contex.Iterneries.Find(iternery_id);
            if (iternery != null)
            {
                contex.Iterneries.Remove(iternery);
                await contex.SaveChangesAsync();
            }
            return iternery;
        }

        public async Task<ActionResult<IEnumerable<Iternery>>> GetAllIternery()
        {
            if (contex.Iterneries == null)
            {
                return null;
            }
            return await contex.Iterneries.ToListAsync();
        }

        public async  Task<ActionResult<Iternery>?> GetIterneryById(int iternery_id)
        {
            if (contex.Iterneries == null)
            {
                return null;
            }
            var iternery = await contex.Iterneries.FindAsync(iternery_id);
            if (iternery == null)
            {
                return null;
            }
            return iternery;
        }

        public async Task<ActionResult<Iternery>> UpdateIternery(int iternery_id,Iternery iternery)
        {
            if (iternery_id != iternery.Iternery_Id)
            {
                return null;
            }

            contex.Entry(iternery).State = EntityState.Modified;

            try
            {
                await contex.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return iternery;
        }
    }
}
