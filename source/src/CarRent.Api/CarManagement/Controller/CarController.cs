using System.Collections.Generic;
using System.Linq;
using CarRent.Api.CarManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Api.CarManagement.Controller
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarController : ControllerBase
  {
    public CarController(ICarService carService)
    {
      CarService = carService;
    }

    private ICarService CarService { get; }

    // GET: api/Car
    [HttpGet]
    public IEnumerable<CarDto> Get()
    {
      var cars = CarService.GetAll();
      return cars.Select(c => new CarDto {Brand = c.Brand});
    }

    // GET: api/Car/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Car
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Car/5
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