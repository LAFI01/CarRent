// ************************************************************************************
// FileName: Customer.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Domain
{
  public class Customer
  {
    public Customer(int customerId, string name, string firstname, string street, string nr, int plz, string palce)
    {
      CustomerId = customerId;
      Name = name;
      Firstname = firstname;
      Street = street;
      StreetNr = nr;
      Plz = plz;
      Place = palce;
    }

    public int CustomerId { get; }

    public string Firstname { get; set; }

    public string Name { get; set; }

    public string Place { get; set; }

    public int Plz { get; set; }

    public string Street { get; set; }

    public string StreetNr { get; set; }
  }
}