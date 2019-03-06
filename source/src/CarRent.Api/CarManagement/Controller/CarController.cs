// ************************************************************************************
// FileName: CarController.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Controller
{
  using System;
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

    [HttpDelete("{id}")]
    public void Delete(int carId)
    {
      CarService.DeleteCar(carId);
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
      throw new NotImplementedException();
    }

    // POST: api/Car
    [HttpPost]
    public void Post([FromBody] CarDto value)
    {
      Car newCar = new Car(value.CarId, value.Brand, value.CarType, value.CarClassFk, value.NumberOfTotalCars,
        value.NumberOfAvailableCars, value.CarClassId, value.CarClass, value.PricePerDay);
      CarService.AddCar(newCar);
    }

    // PUT: api/Car/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
      throw new NotImplementedException();
    }
  }
}