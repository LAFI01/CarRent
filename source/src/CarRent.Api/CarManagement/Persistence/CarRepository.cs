// ************************************************************************************
// FileName: CarRepository.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Persistence
{
  using System.Collections.Generic;
  using Domain;

  public class CarRepository : ICarRepository
  {
    // private readonly static IReadOnlyList<Car> InmemoryCars = new List<Car>() { new Car("Audi"), new Car("BMW") };
    public IReadOnlyList<Car> GetAll()
    {
      // return InmemoryCars
      return null;
    }

    public void AddCar(Car newCar)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCar(int carId)
    {
      throw new System.NotImplementedException();
    }
  }
}