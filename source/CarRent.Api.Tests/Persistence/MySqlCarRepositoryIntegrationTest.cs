// ************************************************************************************
// FileName: MySqlCarRepositoryIntegrationTest.cs
// Author: 
// Created on: 09.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.Tests.Persistence
{
  using CarManagement.Persistence;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class MySqlCarRepositoryIntegrationTest
  {
    private const string Connstr = "Server=localhost;Database=carrent;Uid=root;Pwd=halo1velo;";

    [TestMethod]
    public void GetAll_GetAllCars_CheckSuccess()
    {
      MySqlCarRepository sut = new MySqlCarRepository(Connstr);

      var allCars = sut.GetAll();

      Assert.IsNotNull(allCars);
    }
  }
}