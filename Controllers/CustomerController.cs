using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService service;



        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>?>> GetAllCustomer()
        {
            return await service.GetAllCustomer();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Customer >> GetCustomerById(int Customer_id)
        {
            return await service.GetCustomerById(Customer_id);
        }




        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer Customer)
        {
            return await service.CreateCustomer(Customer);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> UpdateCustomer(int Customer_id, Customer Customer)
        {
            if (Customer_id != Customer.Customer_Id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateCustomer(Customer_id, Customer);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int Customer_id)
        {
            return await service.DeleteCustomer(Customer_id);
        }
    }

}

