using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/iternery")]
    [ApiController]
    public class IterneryController : Controller
    {
        private readonly IIterneryService service;

        public IterneryController(IIterneryService service) 
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Iternery>?>> GetAllIternery()
        {
            return await service.GetAllIternery();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Iternery>> GetIterneryById(int iternery_id)
        {
            return await service.GetIterneryById(iternery_id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Iternery>> UpdateIternery(int iternery_id,Iternery iternery)
        {
            return await service.UpdateIternery(iternery_id, iternery);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Iternery>> DeleteIternery(int iternery_id)
        {
            return await service.DeleteIternery(iternery_id);
        }

        [HttpPost]
        public async Task<ActionResult<Iternery>> CreateIternery(Iternery  iternery)
        {
            return await service.CreateIternery(iternery);
        }
    }
}
