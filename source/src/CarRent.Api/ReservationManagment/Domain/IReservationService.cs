﻿// ************************************************************************************
// FileName: IReservationService.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ReservationManagment.Domain
{
  using System;
  using System.Collections.Generic;

  public interface IReservationService
  {
    void AddReservation(DateTime startDate, DateTime endDate, bool isPickedUp, int customerFk, int carFk,
      decimal carPricePerDay);

    void DeleteReservation(int reservationId);

    IReadOnlyList<Reservation> GetAllReservation();

    void UpdateReservation(bool isPickedUp, int reservationId);
  }
}