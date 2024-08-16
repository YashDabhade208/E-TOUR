using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eTour.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService service;
        private readonly IConfiguration configuration;



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


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid request.");

            // Replace this with your Customer validation logic
            var Customer = ValidateCustomer(model.Email, model.Password);
            if (Customer == null)
                return Unauthorized("Invalid email or password.");

            var token = GenerateJwtToken(Customer);
            return Ok(new { Token = token });
        }

        private Customer ValidateCustomer(string email, string password)
        {
            // TODO: Implement your Customer validation logic
            // This is just a placeholder for demonstration purposes
            if (email == "test@example.com" && password == "password")
            {
                return new Customer { Customer_EmailId = email };
            }
            return null;
        }

        private string GenerateJwtToken(Customer customer)
        {
            var jwtSettings = configuration.GetSection("Jwt");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, customer.Customer_EmailId)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = jwtSettings["Issuer"],
                Audience = jwtSettings["Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        public string Email { get; set; }
    }
}



