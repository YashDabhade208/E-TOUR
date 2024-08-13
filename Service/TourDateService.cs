using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace eTour.Service
{
    public class TourDateService : ITourDateService
    {
        private readonly Appdbcontext contex;
        public TourDateService(Appdbcontext contex)
        {
            this.contex = contex;
        }
        public async Task<ActionResult<TourDate>> CreateTourDate(TourDate tourdate)
        {
            contex.TourDates.Add(tourdate);
            await contex.SaveChangesAsync();
            return tourdate;

        }

        public async Task<ActionResult<TourDate>> DeleteDate(int tourdate_id)
        {
            TourDate tourdate = contex.TourDates.Find(tourdate_id);
            if (tourdate != null)
            {
                contex.TourDates.Remove(tourdate);
                await contex.SaveChangesAsync();
            }
            return tourdate;
        }

        public async Task<ActionResult<IEnumerable<TourDate>?>> GetAllTourDate()
        {
            if (contex.TourDates == null)
            {
                return null;
            }
            return await contex.TourDates.ToListAsync();
        }

        public async Task<ActionResult<TourDate>> GetTourDateById(int tourdate_id)
        {
            if (contex.TourDates == null)
            {
                return null;
            }
            var tourdate = await contex.TourDates.FindAsync(tourdate_id);
            if (tourdate == null)
            {
                return null;
            }
            return tourdate;
        }

        public async Task<ActionResult<TourDate>> UpdateDate(int tourdate_id, TourDate tourdate)
        {
            if (tourdate_id != tourdate.Tourdate_Id)
            {
                return null;
            }

            contex.Entry(tourdate).State = EntityState.Modified;

            try
            {
                await contex.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return tourdate;
        }
    }
}
