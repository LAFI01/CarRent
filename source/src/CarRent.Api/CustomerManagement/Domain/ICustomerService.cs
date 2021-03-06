﻿// ************************************************************************************
// FileName: ICustomerService.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Domain
{
  using System.Collections.Generic;

  public interface ICustomerService
  {
    void AddCustomer(Customer newCustomer);

    void DeleteCustomer(int customerId);

    IReadOnlyList<Customer> GetAll();
  }
}