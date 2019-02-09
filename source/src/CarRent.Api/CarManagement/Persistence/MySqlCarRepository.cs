using System.Collections.Generic;
using System.Data;
using CarRent.Api.CarManagement.Domain;
using MySql.Data.MySqlClient;

namespace CarRent.Api.CarManagement.Persistence
{
  public class MySqlCarRepository : ICarRepository
  {
    public MySqlCarRepository(string connectionString)
    {
      MySqlConnection = new MySqlConnection(connectionString);
    }

    private IDbConnection MySqlConnection { get; }

    public IReadOnlyList<Car> GetAll()
    {
      IList<Car> allCars = new List<Car>();

      try
      {
        MySqlConnection.Open();
        using (MySqlConnection.BeginTransaction())
        {
          var command = MySqlConnection.CreateCommand();
          command.CommandText =
            "SELECT idCar, brand, type, isAvailable, numberOfCars, designation, pricePerDay FROM car INNER JOIN carClass ON car.fkCarClass = carClass.idCarClass;";

          using (var reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              var newCar = new Car(ConvertToInt(reader.GetValue(0)), reader.GetString(1), reader.GetString(2),
                ConvertToBool(reader.GetValue(3)), ConvertToInt(reader.GetValue(4)), reader.GetString(5),
                ConvertToDecimal(reader.GetValue(6)));
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

    private int ConvertToInt(object obj)
    {
      var i = 0;
      if (obj is int)
      {
        i = (int) obj;
      }

      return i;
    }

    private bool ConvertToBool(object obj)
    {
      var i = false;
      if (obj is bool)
      {
        i = (bool) obj;
      }

      return i;
    }

    private decimal ConvertToDecimal(object obj)
    {
      decimal i = 0;
      if (obj is decimal @decimal)
      {
        i = @decimal;
      }

      return i;
    }
  }
}