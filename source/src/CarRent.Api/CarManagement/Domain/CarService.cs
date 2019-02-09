using System.Collections.Generic;

namespace CarRent.Api.CarManagement.Domain
{
  internal class CarService : ICarService
  {
    public CarService(ICarRepository carRepository)
    {
      CarRepository = carRepository;
    }

    private ICarRepository CarRepository { get; }

    public IReadOnlyList<Car> GetAll()
    {
      return CarRepository.GetAll();
    }
  }
}