using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Api.CarManagement.Domain;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CarRent.Api.CarManagement.Persistence
{
  public class CarRepository : ICarRepository
  {
    //private readonly static IReadOnlyList<Car> InmemoryCars = new List<Car>() { new Car("Audi"), new Car("BMW") };
    public IReadOnlyList<Car> GetAll()
    {
      //return InmemoryCars;
      return  null;
    }
  }
}
