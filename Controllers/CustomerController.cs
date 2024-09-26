using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eTour.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        private readonly IConfiguration configuration;

        public CustomerController(ICustomerService service, IConfiguration configuration)
        {
            this.service = service;
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>?>> GetAllCustomer()
        {
            return await service.GetAllCustomer();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            var customer = await service.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        /* [HttpPost]
         public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
         {
             var createdCustomer = await service.CreateCustomer(customer);
             return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.Value.Customer_Id }, createdCustomer);
         }*/
        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            try
            {
                throw new Exception("Simulated failure in .NET service");
                var createdCustomer = await service.CreateCustomer(customer);
                return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.Value.Customer_Id }, createdCustomer);
            }
            catch (Exception ex)
            {
            
                Console.WriteLine("Error in .NET service: " + ex.Message);

                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsJsonAsync("http://localhost:8080/api/customer", customer);

                        if (response.IsSuccessStatusCode)
                        {
                            var jsonResponse = await response.Content.ReadAsStringAsync();
                            var createdCustomerFromSpringBoot = JsonConvert.DeserializeObject<Customer>(jsonResponse);
                            return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomerFromSpringBoot.Customer_Id }, createdCustomerFromSpringBoot);
                        }
                        else
                        {
                            return StatusCode((int)response.StatusCode, "Failed to create customer in Spring Boot service");
                        }
                    }
                }
                catch (Exception springBootEx)
                {
                    Console.WriteLine("Error in Spring Boot service: " + springBootEx.Message);
                    return StatusCode(500, "Both .NET and Spring Boot services failed");
                }
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCustomer(int id, Customer customer)   
        {
            if (id != customer.Customer_Id)
            {
                return BadRequest();
            }

            try
            {
                await service.UpdateCustomer(id, customer);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int id)
        {
            var customer = await service.DeleteCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (service.ValidateCustomer(login.Email, login.Password))
            {
                var user = new User { Email = login.Email };
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Email", user.Email)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(40  ),
                    signingCredentials: signIn
                );

                var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });
            }
            else
            {
                return Unauthorized(new { Message = "Invalid email or password" });
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
}
