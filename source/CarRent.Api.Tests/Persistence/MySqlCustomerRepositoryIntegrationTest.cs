using System;
using System.Collections.Generic;
using System.Text;

namespace CarRent.Api.Tests.Persistence
{
  using CustomerManagement.Persistence;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
 public class MySqlCustomerRepositoryIntegrationTest
  {
    private const string Connstr = "Server=localhost;Database=carrent;Uid=root;Pwd=halo1velo;";

    [TestMethod]
    public void CRUD_CreateNewCustomer_CheckSuccess()
    {
      //arrange
      MySqlCustomerRepository sut = new MySqlCustomerRepository(Connstr);
      string name = "Huber";
      string firstname = "Fritz";
      string street = "Weierweg";
      string nr = "25c";
      int plz = 9000;
      string city = "Gossau";

      //act
      var numberOfCustomerBefore = sut.GetAll().Count;
      sut.CreateCustomer(name, firstname, street, nr, plz, city);
      var allCustomer = sut.GetAll();
      var numberOfCustomerAfter = allCustomer.Count;
      var customerIdHuber = allCustomer[numberOfCustomerAfter - 1].CustomerId;
      sut.DeleteCustomer(customerIdHuber);

      //assert
      Assert.IsTrue(numberOfCustomerBefore < numberOfCustomerAfter);

    }
  }
}
