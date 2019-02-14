namespace CarRent.Api.CarManagement.Domain
{
  public class Car
  {
    public Car(int id, string brand, string type, bool isAvailable, int numberOfCars, string designation,
      decimal pricePerDay)
    {
      CarId = id;
      CarType = type;
      IsAvailable = isAvailable;
      NumberOfCars = numberOfCars;
      CarClass = designation;
      PricePerDay = pricePerDay;
      Brand = brand;
    }

    public string Brand { get; set; }

    public int CarId { get; }

    public string CarType { get; set; }

    public bool IsAvailable { get; set; }

    public int NumberOfCars { get; set; }

    public string CarClass { get; set; }

    public decimal PricePerDay { get; set; }
  }
}