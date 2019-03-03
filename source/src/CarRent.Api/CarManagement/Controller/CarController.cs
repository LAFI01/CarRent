// ************************************************************************************
// FileName: CarController.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Controller
{
  using System.Collections.Generic;
  using System.Linq;
  using Domain;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  [ApiController]
  public class CarController : ControllerBase
  {
    public CarController(ICarService carService)
    {
      CarService = carService;
    }

    private ICarService CarService { get; }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    // GET: api/Car
    [HttpGet]
    public IEnumerable<CarDto> Get()
    {
      var cars = CarService.GetAll();

      return cars.Select(c => new CarDto
      {
        Brand = c.Brand,
        CarClass = c.CarClass,
        CarId = c.CarId,
        CarType = c.CarType,
        NumberOfAvailableCars = c.NumberOfAvailableCars,
        CarClassFk = c.CarClassFk,
        NumberOfTotalCars = c.NumberOfTotalCars,
        CarClassId = c.CarClassId,
        PricePerDay = c.PricePerDay
      });
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
  }
}