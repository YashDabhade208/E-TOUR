using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface ICustomerService
    {
        Task<ActionResult<Customer>?> GetCustomerById(int customer_id);
        Task<ActionResult<IEnumerable<Customer>>> GetAllCustomer();
        Task<ActionResult<Customer>> CreateCustomer(Customer customer);
        Task<ActionResult<Customer>> UpdateCustomer(int customer_id, Customer customer);
        Task<Customer> DeleteCustomer(int customer_id);
        bool ValidateCustomer(string email, string password);
    }
}
