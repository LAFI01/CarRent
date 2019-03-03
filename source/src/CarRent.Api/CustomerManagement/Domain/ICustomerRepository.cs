// ************************************************************************************
// FileName: ICustomerRepository.cs
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
  using System.Collections.Generic;

  public interface ICustomerRepository
  {
    void CreateCustomer(string name, string firstname, string street, string nr, int plz, string city);

    void DeleteCustomer(int customerId);

    IReadOnlyList<Customer> GetAll();
  }
}