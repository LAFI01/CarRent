// ************************************************************************************
// FileName: Customer.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Domain
{
  public class Customer
  {
    public Customer(int customerId, string name, string firstname, int addressFk, int addressId, string street,
      string nr, int cityFk, int cityId, int plz, string palce)
    {
      CustomerId = customerId;
      Name = name;
      Firstname = firstname;
      AddressFk = addressFk;
      AddressId = addressId;
      Street = street;
      StreetNr = nr;
      CityFk = cityFk;
      CityId = cityId;
      Plz = plz;
      Place = palce;
    }

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