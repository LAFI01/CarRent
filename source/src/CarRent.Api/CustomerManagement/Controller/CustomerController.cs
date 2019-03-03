// ************************************************************************************
// FileName: CustomerController.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Controller
{
  using System.Collections.Generic;
  using System.Linq;
  using Domain;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    public CustomerController(ICustomerService customerService)
    {
      CustomerService = customerService;
    }

    private ICustomerService CustomerService { get; }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

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
        AddressFk = c.AddressFk,
        AddressId = c.AddressId,
        Street = c.Street,
        StreetNr = c.StreetNr,
        CityFk = c.CityFk,
        CityId = c.CityId,
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
  }
}