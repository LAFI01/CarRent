// ************************************************************************************
// FileName: CustomerDto.cs
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
  public class CustomerDto
  {
    public int AddressFk { get; set; }

    public int AddressId { get; set; }

    public int CityFk { get; set; }

    public int CityId { get; set; }

    public int CustomerId { get; set; }

    public string Firstname { get; set; }

    public string Name { get; set; }

    public string Place { get; set; }

    public int Plz { get; set; }

    public string Street { get; set; }

    public string StreetNr { get; set; }
  }
}