namespace CarRent.Api.CarManagement.Domain
{
  using System.Collections.Generic;

  public interface ICarService
  {
    IReadOnlyList<Car> GetAll();

    void AddCar(Car car);
  }
}