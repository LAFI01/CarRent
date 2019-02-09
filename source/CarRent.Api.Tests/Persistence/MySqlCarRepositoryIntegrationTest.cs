using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using CarRent.Api.CarManagement.Domain;
using CarRent.Api.CarManagement.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRent.Api.Tests.Persistence
{
  [TestClass]
  public class MySqlCarRepositoryIntegrationTest
  {
    private const string Connstr = "Server=localhost;Database=carrent;Uid=root;Pwd=halo1velo;";

    [TestMethod]

    public void GetAll_GetAllCars_CheckSuccess()
    {
      MySqlCarRepository sut = new MySqlCarRepository(Connstr);

      IReadOnlyList<Car> allCars = sut.GetAll();

      Assert.IsNotNull(allCars);
    }

  }
}
