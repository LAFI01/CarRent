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

    public void AddCar(Car car)
    {
      CarRepository.AddCar(car);
    }

    public void DeleteCar(int carId)
    {
      CarRepository.DeleteCar(carId);
    }
  }
}