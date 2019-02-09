using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Api.CarManagement.Domain
{
  interface ICarRepository
  {
    IReadOnlyList<Car> GetAll();
  }
}
