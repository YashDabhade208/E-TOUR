using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface IIterneryService
    {
        Task <ActionResult<Iternery>?> GetIterneryById(int iternery_id);
        Task<ActionResult<IEnumerable<Iternery>>> GetAllIternery();
        Task <ActionResult<Iternery>>CreateIternery(Iternery iternery);
        Task<ActionResult<Iternery>> UpdateIternery(int iternery_id,Iternery iternery);
        Task <Iternery> DeleteIternery(int iternery_id);
        Task<List<Iternery>> GetIterneryByTourId(int Tour_Id);
    }
}
