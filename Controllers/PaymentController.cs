using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : Controller
    {


        private readonly IPaymentService service;



        public PaymentController(IPaymentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>?>> GetAllPayment()
        {
            return await service.GetAllPayment();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPaymentById(int Payment_id)
        {
            return await service.GetPaymentById(Payment_id);
        }




        [HttpPost]
        public async Task<ActionResult<Payment>> CreatePayment(Payment payment)
        {
            return await service.CreatePayment(payment);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePayment(int Payment_id, Payment payment)
        {
            if (Payment_id != payment.Payment_Id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdatePayment(Payment_id, payment);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Payment>> DeletePayment(int Payment_id)
        {
            return await service.DeletePayment(Payment_id);
        }
    }
}
