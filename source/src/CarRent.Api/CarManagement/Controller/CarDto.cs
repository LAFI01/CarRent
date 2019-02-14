// ************************************************************************************
// FileName: CarDto.cs
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
  using Newtonsoft.Json;

  public class CarDto
  {
    // so kann hier das Property anders heissen, wie der Name, welcher ich nach draussen gebe!
    [JsonProperty(PropertyName = "Brand")]
    public string Brand { get; set; }

    public string CarClass { get; set; }

    public int CarId { get; set; }

    public string CarType { get; set; }

    public bool IsAvailable { get; set; }

    public int NumberOfCars { get; set; }

    public decimal PricePerDay { get; set; }
  }
}