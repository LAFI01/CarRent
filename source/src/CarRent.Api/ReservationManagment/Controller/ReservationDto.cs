// ************************************************************************************
// FileName: ReservationDto.cs
// Author: 
// Created on: 03.03.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ReservationManagment.Controller
{
  using System;

  public class ReservationDto
  {
    public int CarFk { get; set; }

    public int CustomerFk { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsPickedUp { get; set; }

    public int ReservationId { get; set; }

    public DateTime StartDate { get; set; }

    public decimal TotalPrice { get; set; }
  }
}