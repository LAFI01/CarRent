// ************************************************************************************
// FileName: MySqlReservationRepository.cs
// Author: 
// Created on: 03.03.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.ReservationManagment.Persistence
{
  using System.Collections.Generic;
  using System.Data;
  using Common.Persistence;
  using Domain;
  using MySql.Data.MySqlClient;

  public class MySqlReservationRepository : MySqlBaseRespository, IReservationRepository
  {
    public MySqlReservationRepository(string connectionString) : base(connectionString)
    {
    }

    public void CreateReservation(Reservation newReservation)
    {
      try
      {
        MySqlConnection.Open();
        IDbCommand cmd = CreateCommand(MySqlConnection, CommandType.StoredProcedure, "p_new_reservation");

        MySqlParameter p1 = new MySqlParameter("_startDate", newReservation.StartDate);
        p1.Direction = ParameterDirection.Input;
        p1.DbType = DbType.DateTime;

        MySqlParameter p2 = new MySqlParameter("_endDate", newReservation.EndDate);
        p2.Direction = ParameterDirection.Input;
        p2.DbType = DbType.DateTime;

        MySqlParameter p3 = new MySqlParameter("_totalPrice", newReservation.TotalPrice);
        p3.Direction = ParameterDirection.Input;
        p3.DbType = DbType.Decimal;

        MySqlParameter p4 = new MySqlParameter("_isPickedUp", newReservation.IsPickedUp);
        p4.Direction = ParameterDirection.Input;
        p4.DbType = DbType.Boolean;

        MySqlParameter p5 = new MySqlParameter("_customerFk", newReservation.CustomerFk);
        p5.Direction = ParameterDirection.Input;
        p5.DbType = DbType.Int32;

        MySqlParameter p6 = new MySqlParameter("_carFk", newReservation.CarFk);
        p6.Direction = ParameterDirection.Input;
        p6.DbType = DbType.Int32;

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);
        cmd.Parameters.Add(p6);

        cmd.ExecuteNonQuery();
      }
      finally
      {
        MySqlConnection.Close();
      }
    }

    public void DeleteReservation(int reservationId)
    {
      DeleteRow("reservation", "idReservation", reservationId);
    }

    public IReadOnlyList<Reservation> GetAllReservation()
    {
      IList<Reservation> allReservation = new List<Reservation>();
      try
      {
        MySqlConnection.Open();
        using (MySqlConnection.BeginTransaction())
        {
          IDbCommand command = CreateCommand(MySqlConnection, CommandType.Text,
            "SELECT * FROM reservation;");

          using (IDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              Reservation newReservation = new Reservation(
                ConvertToInt(reader.GetValue(0)), ConvertToDateTime(reader.GetValue(1)),
                ConvertToDateTime(reader.GetValue(2)),
                ConvertToDecimal(reader.GetValue(3)), ConvertToBool(reader.GetValue(4)),
                ConvertToInt(reader.GetValue(5)), ConvertToInt(reader.GetValue(6)));
              allReservation.Add(newReservation);
            }

            reader.Close();
          }
        }
      }
      finally
      {
        MySqlConnection.Close();
      }

      return (IReadOnlyList<Reservation>) allReservation;
    }

    public void UpdateReservation(bool isPickedUp, int reservationId)
    {
      UpdateRow("reservation", "isPickedUp", isPickedUp, reservationId, "idReservation");
    }
  }
}