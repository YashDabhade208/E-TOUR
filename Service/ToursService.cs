using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class ToursService : IToursService
    {

        private readonly Appdbcontext context;
        public ToursService(Appdbcontext context) 
        {
            this.context = context;
        }
        public async Task<ActionResult<Tours>> CreateTours(Tours tour)
        {
            context.Tour.AddAsync(tour);
            await context.SaveChangesAsync();
            return tour;
        }

        public async Task<Tours> DeleteTours(int tour_id)
        {
            Tours tours=context.Tour.Find(tour_id);
            if(tours !=null)
            {
                context.Tour.Remove(tours);
                await context.SaveChangesAsync() ;
            }
            return tours;
        }

        public async Task<ActionResult<IEnumerable<Tours>>> GetAllTours()
        {
            return await context.Tour.ToListAsync();
        }

        public async Task<ActionResult<Tours>?> GetToursById(int id)
        {
            var tours = await context.Tour.FindAsync(id);
            if (tours == null)
            {
                return null;
            }
            return tours;
        }

        public async Task<ActionResult<Tours>> UpdateTours(int tour_id, Tours tour)
        {
            if(tour_id != tour.Tour_Id)
            {
                return null;
            }
            context.Entry(tour).State = EntityState.Modified;
             try
            {
                await context.SaveChangesAsync();
            }
            catch { Console.WriteLine("NOT UPDATED"); }

            return tour;
                
        }
    }
}
