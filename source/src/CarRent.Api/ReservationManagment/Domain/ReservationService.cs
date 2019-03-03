// ************************************************************************************
// FileName: ReservationService.cs
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

  public class ReservationService : IReservationService
  {
    public ReservationService(IReservationRepository reservationRepository)
    {
      ReservationRepository = reservationRepository;
    }

    private IReservationRepository ReservationRepository { get; }

    public IReadOnlyList<Reservation> GetAllReservation()
    {
      return ReservationRepository.GetAllReservation();
    }

    public void UpdateReservation(bool isPickedUp, int reservationId)
    {
      ReservationRepository.UpdateReservation(isPickedUp, reservationId);
    }

    public void DeleteReservation(int reservationId)
    {
      ReservationRepository.DeleteReservation(reservationId);
    }

    public void AddReservation(DateTime startDate, DateTime endDate, bool isPickedUp, int customerFk, int carFk,
      decimal carPricePerDay)
    {
      ReservationRepository.CreateReservation(startDate, endDate,
        CalculateTotalPrice(startDate, endDate, carPricePerDay), isPickedUp, customerFk,
        carFk);
    }

    private decimal CalculateTotalPrice(DateTime start, DateTime end, decimal carPricePerDay)
    {
      var numberOfDays = end.Subtract(start).Days;

      return numberOfDays * carPricePerDay;
    }
  }
}