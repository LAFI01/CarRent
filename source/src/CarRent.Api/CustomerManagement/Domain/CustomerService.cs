// ************************************************************************************
// FileName: CustomerService.cs
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
  using System.Collections.Generic;

  public class CustomerService : ICustomerService
  {
    public CustomerService(ICustomerRepository customerRepository)
    {
#pragma warning disable SA1101 // Prefix local calls with this
      CustomerRepository = customerRepository;
#pragma warning restore SA1101 // Prefix local calls with this
    }

    public ICustomerRepository CustomerRepository { get; }


    public IReadOnlyList<Customer> GetAll()
    {
      return CustomerRepository.GetAll();
    }
  }
}