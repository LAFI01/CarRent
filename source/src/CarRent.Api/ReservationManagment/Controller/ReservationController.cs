// ************************************************************************************
// FileName: ReservationController.cs
// Author: 
// Created on: 03.03.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ReservationManagment.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Domain;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  [ApiController]
  public class ReservationController : ControllerBase
  {
    public ReservationController(IReservationService reservationService)
    {
      ReservationService = reservationService;
    }

    private IReservationService ReservationService { get; }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int reservationId)
    {
      ReservationService.DeleteReservation(reservationId);
    }

    // GET: api/Reservation
    [HttpGet]
    public IEnumerable<ReservationDto> Get()
    {
      var reservations = ReservationService.GetAllReservation();

      return reservations.Select(r => new ReservationDto
      {
        ReservationId = r.ReservationId,
        CarFk = r.CarFk,
        CustomerFk = r.CustomerFk,
        EndDate = r.EndDate,
        IsPickedUp = r.IsPickedUp,
        StartDate = r.StartDate,
        TotalPrice = r.TotalPrice
      });
    }

    // GET: api/Reservation/5
    [HttpGet]
    public string Get(int id)
    {
      throw new NotImplementedException();
    }

    // POST: api/Reservation
    [HttpPost]
    public void Post([FromBody] ReservationDto value)
    {
      Reservation newReservation = new Reservation(value.ReservationId, value.StartDate, value.EndDate,
        value.TotalPrice, value.IsPickedUp, value.CustomerFk, value.CarFk);
      ReservationService.AddReservation(newReservation);
    }

    // PUT: api/Reservation/5
    [HttpPut("{id}")]
    public void Put(int reservationId, [FromBody] bool isPickedUp)
    {
      ReservationService.UpdateReservation(isPickedUp, reservationId);
    }
  }
}