using System;
using System.Collections.Generic;
using System.Text;

namespace CarRent.Api.Tests.Domain
{
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using ReservationManagment.Domain;
  using ReservationManagment.Persistence;

  [TestClass]
  public class ReservationServiceIntegrationTest
  {
    private const string Connstr = "Server=localhost;Database=carrent;Uid=root;Pwd=halo1velo;";

    [TestMethod]
    public void CRUD_CreateAndDeleteReservation_CheckSuccress()
    {

      //arrange
      IReservationRepository reservationRepository = new MySqlReservationRepository(Connstr);
      IReservationService sut = new ReservationService(reservationRepository);
      DateTime startDate = new DateTime(2019, 04, 25, 10,00,00);
      DateTime endDate = new DateTime(2019, 04, 29, 10, 00, 00);
      bool isPickedUp = false;
      int customerFk = 1;
      int carFk = 1;
      decimal carPricePerDay = 30.35m;


      //act
      int reservationCountBefor = sut.GetAllReservation().Count;
      sut.AddReservation(startDate, endDate, isPickedUp, customerFk, carFk, carPricePerDay);
      IReadOnlyList<Reservation> reservations = sut.GetAllReservation();
      int reservationCountAfter = reservations.Count;
      int reservationId = reservations[reservationCountAfter - 1].ReservationId;
      sut.UpdateReservation(true, reservationId);
      sut.DeleteReservation(reservationId);

      //assert
      Assert.IsTrue(reservationCountBefor < reservationCountAfter);
    }
  }
}
