﻿// ************************************************************************************
// FileName: Reservation.cs
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

  public class Reservation
  {
    public Reservation(int reservationId, DateTime startDate, DateTime endDate, decimal totalPrice, bool isPickedUp,
      int customerFk, int carFk)
    {
      ReservationId = reservationId;
      StartDate = startDate;
      EndDate = endDate;
      TotalPrice = totalPrice;
      IsPickedUp = isPickedUp;
      CustomerFk = customerFk;
      CarFk = carFk;
    }

    public int CarFk { get; set; }

    public int CustomerFk { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsPickedUp { get; set; }

    public int ReservationId { get; set; }

    public DateTime StartDate { get; set; }

    public decimal TotalPrice { get; set; }
  }
}