// ************************************************************************************
// FileName: MySqlCarRepository.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CarManagement.Persistence
{
  using System.Collections.Generic;
  using System.Data;
  using Common.Persistence;
  using Domain;
  using MySql.Data.MySqlClient;

  public class MySqlCarRepository : MySqlBaseRespository, ICarRepository
  {
    public MySqlCarRepository(string connectionString) : base(connectionString)
    {
      MySqlConnection = new MySqlConnection(connectionString);
    }

    public void AddCar(Car newCar)
    {
      try
      {
        MySqlConnection.Open();
        IDbCommand cmd = CreateCommand(MySqlConnection, CommandType.StoredProcedure, "p_new_car");

        MySqlParameter p1 = new MySqlParameter("_brand", newCar.Brand);
        p1.Direction = ParameterDirection.Input;
        p1.DbType = DbType.String;

        MySqlParameter p2 = new MySqlParameter("_type", newCar.CarType);
        p2.Direction = ParameterDirection.Input;
        p2.DbType = DbType.String;

        MySqlParameter p3 = new MySqlParameter("_fkCarClass", newCar.CarClassFk);
        p3.Direction = ParameterDirection.Input;
        p3.DbType = DbType.Int32;

        MySqlParameter p4 = new MySqlParameter("_numberOfCars", newCar.NumberOfTotalCars);
        p4.Direction = ParameterDirection.Input;
        p4.DbType = DbType.Int32;

        MySqlParameter p5 = new MySqlParameter("_numberOfAvailableCars", newCar.NumberOfAvailableCars);
        p5.Direction = ParameterDirection.Input;
        p5.DbType = DbType.Int32;

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);

        cmd.ExecuteNonQuery();
      }
      finally
      {
        MySqlConnection.Close();
      }
    }


    public IReadOnlyList<Car> GetAll()
    {
      IList<Car> allCars = new List<Car>();

      try
      {
        MySqlConnection.Open();
        using (MySqlConnection.BeginTransaction())
        {
          IDbCommand command = CreateCommand(MySqlConnection, CommandType.Text, "SELECT * FROM v_car;");

          using (IDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              Car newCar = new Car(ConvertToInt(reader.GetValue(0)), reader.GetString(1), reader.GetString(2),
                ConvertToInt(reader.GetValue(3)), ConvertToInt(reader.GetValue(4)), ConvertToInt(reader.GetValue(5)),
                ConvertToInt(reader.GetValue(6)), reader.GetString(7),
                ConvertToDecimal(reader.GetValue(8)));
              allCars.Add(newCar);
            }

            reader.Close();
          }
        }
      }
      finally
      {
        MySqlConnection.Close();
      }

      return (IReadOnlyList<Car>) allCars;
    }
  }
}