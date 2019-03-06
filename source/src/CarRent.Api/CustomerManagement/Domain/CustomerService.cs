// ************************************************************************************
// FileName: CustomerService.cs
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

  public class CustomerService : ICustomerService
  {
    public CustomerService(ICustomerRepository customerRepository)
    {
      CustomerRepository = customerRepository;
    }

    private ICustomerRepository CustomerRepository { get; }


    public void AddCustomer(Customer newCustomer)
    {
      CustomerRepository.AddCustomer(newCustomer);
    }

    public void DeleteCustomer(int customerId)
    {
      CustomerRepository.DeleteCustomer(customerId);
    }

    public IReadOnlyList<Customer> GetAll()
    {
      return CustomerRepository.GetAll();
    }
  }
}