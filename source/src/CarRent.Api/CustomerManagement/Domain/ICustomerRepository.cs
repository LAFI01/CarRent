using System.Collections.Generic;

namespace CarRent.Api.CustomerManagement.Domain
{
  public interface ICustomerRepository
  {
    IReadOnlyList<Customer> GetAll();
  }
}