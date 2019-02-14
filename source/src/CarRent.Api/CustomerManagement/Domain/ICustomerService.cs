namespace CarRent.Api.CustomerManagement.Domain
{
  using System.Collections.Generic;

  public interface ICustomerService
  {
    IReadOnlyList<Customer> GetAll();
  }
}