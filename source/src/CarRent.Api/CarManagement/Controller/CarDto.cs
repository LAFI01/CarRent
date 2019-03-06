// ************************************************************************************
// FileName: CarDto.cs
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
  using Newtonsoft.Json;

  public class CarDto
  {
    // so kann hier das Property anders heissen, wie der Name, welcher ich nach draussen gebe!
    [JsonProperty(PropertyName = "Brand")]
    public string Brand { get; set; }

    public string CarClass { get; set; }

    public int CarClassFk { get; set; }

    public int CarClassId { get; set; }

    public int CarId { get; set; }

    public string CarType { get; set; }

    public int NumberOfAvailableCars { get; set; }

    public int NumberOfTotalCars { get; set; }

    public decimal PricePerDay { get; set; }
  }
}