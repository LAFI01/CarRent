// ************************************************************************************
// FileName: Car.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Domain
{
  public class Car
  {
    public Car(int id, string brand, string type,  int carClassFk, int numberOfTotalCars, int numberOfAvailableCars, int carClassId,
      string designation,
      decimal pricePerDay)
    {
      CarId = id;
      CarType = type;
      NumberOfAvailableCars = numberOfAvailableCars;
      NumberOfTotalCars = numberOfTotalCars;
      CarClass = designation;
      PricePerDay = pricePerDay;
      Brand = brand;
      CarClassFk = carClassFk;
      CarClassId = carClassId;
    }

    public string Brand { get; set; }

    public string CarClass { get; set; }

    public int CarClassFk { get; set; }

    public int CarClassId { get; set; }

    public int CarId { get; }

    public string CarType { get; set; }

    public int NumberOfAvailableCars { get; set; }

    public int NumberOfTotalCars { get; set; }

    public decimal PricePerDay { get; set; }
  }
}