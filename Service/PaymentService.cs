using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly Appdbcontext context;

        public  PaymentService(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<Payment>> CreatePayment(Payment payment)
        {
            context.Payments.Add(payment);
            await context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> DeletePayment(int Payment_id)
        {
            Payment payment = context.Payments.Find(Payment_id);
            if (payment != null)
            {
                context.Payments.Remove(payment);
                await context.SaveChangesAsync();
            }
            return payment;
        }

        public async Task<ActionResult<IEnumerable<Payment>>> GetAllPayment()
        {
            return await context.Payments.ToListAsync();
        }

        public async Task<ActionResult<Payment>?> GetPaymentById(int Payment_id)
        {
            var payment = await context.Payments.FindAsync(Payment_id);
            if (payment == null)
            {
                return null;
            }
            return payment;
        }

        public async Task<ActionResult<Payment>> UpdatePayment(int Payment_id, Payment payment)
        {
            if (Payment_id != payment.Payment_Id)
            {
                return null;
            }

            context.Entry(payment).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return payment;
        }
    }
}
