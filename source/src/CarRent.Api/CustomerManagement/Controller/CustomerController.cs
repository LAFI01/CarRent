using System.Collections.Generic;
using System.Linq;
using CarRent.Api.CustomerManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Api.CustomerManagement.Controller
{
  [Route("api/[controller]")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    public CustomerController(ICustomerService customerService)
    {
      CustomerService = customerService;
    }

    private ICustomerService CustomerService { get; }

    // GET: api/Customer
    [HttpGet]
    public IEnumerable<CustomerDto> Get()
    {
      var customers = CustomerService.GetAll();
      return customers.Select(c => new CustomerDto
      {
        CustomerId = c.CustomerId,
        Name = c.Name,
        Firstname = c.Firstname,
        Street = c.Street,
        StreetNr = c.StreetNr,
        Plz = c.Plz,
        Place = c.Place
      });
    }

    // GET: api/Customer/5


    // POST: api/Customer
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Customer/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}