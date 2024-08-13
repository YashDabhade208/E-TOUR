using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface ITourDateService
    {
        Task<ActionResult<IEnumerable<TourDate>?>> GetAllTourDate();
        Task <ActionResult<TourDate>> GetTourDateById(int tourdate_id);
        Task <ActionResult<TourDate>> CreateTourDate(TourDate tourdate);
        Task<ActionResult<TourDate>> UpdateDate(int tourdate_id, TourDate tourdate);
        Task<ActionResult<TourDate>> DeleteDate(int tourdate_id);
    }
}
