using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface IPaymentService
    {
        Task<ActionResult<Payment>?> GetPaymentById(int Payment_id);
        Task<ActionResult<IEnumerable<Payment>>> GetAllPayment();
        Task<ActionResult<Payment>> CreatePayment(Payment payment);
        Task<ActionResult<Payment>> UpdatePayment(int Payment_id, Payment payment);
        Task<Payment> DeletePayment(int Payment_id);
    }
}
