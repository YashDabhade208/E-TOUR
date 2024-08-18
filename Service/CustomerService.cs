using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly Appdbcontext context;

        public CustomerService(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int customer_id)
        {
            Customer customer = context.Customers.Find(customer_id);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                await context.SaveChangesAsync();
            }
            return customer;
        }

        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomer()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task<ActionResult<Customer>?> GetCustomerById(int customer_id)
        {
            var customer = await context.Customers.FindAsync(customer_id);
            if (customer == null)
            {
                return null;
            }
            return customer;
        }

        public async Task<ActionResult<Customer>> UpdateCustomer(int customer_id, Customer customer)
        {
            if (customer_id != customer.Customer_Id)
            {
                return null;
            }
            context.Entry(customer).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return customer;
        }

        public bool ValidateCustomer(string email, string password)
        {
            var customer = context.Customers
                               .FirstOrDefault(c => c.Customer_EmailId == email);

            
            return customer != null && customer.Customer_Password == password;

        }
    }
}
