using System.Collections.Generic;

namespace CarRent.Api.CarManagement.Domain
{
  public interface ICarService
  {
    IReadOnlyList<Car> GetAll();
  }
}