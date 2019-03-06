// ************************************************************************************
// FileName: IReservationRepository.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ReservationManagment.Domain
{
  using System;
  using System.Collections.Generic;

  public interface IReservationRepository
  {
    void CreateReservation(Reservation newReservation);

    IReadOnlyList<Reservation> GetAllReservation();

    void DeleteReservation(int reservationId);

    void UpdateReservation(bool isPickedUp, int reservationId);
  }
}