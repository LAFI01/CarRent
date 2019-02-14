// ************************************************************************************
// FileName: MySqlCustomerRepository.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Persistence
{
  using System.Collections.Generic;
  using System.Data;
  using Domain;
  using MySql.Data.MySqlClient;

  public class MySqlCustomerRepository : ICustomerRepository
  {
    public MySqlCustomerRepository(string connectionString)
    {
      MySqlConnection = new MySqlConnection(connectionString);
    }

    private IDbConnection MySqlConnection { get; }


    public IReadOnlyList<Customer> GetAll()
    {
      IList<Customer> allCustomers = new List<Customer>();
      try
      {
        MySqlConnection.Open();
        using (MySqlConnection.BeginTransaction())
        {
          IDbCommand command = MySqlConnection.CreateCommand();
          command.CommandText =
            "SELECT cu.idCustomer, cu.name, cu.firstname, a.street, a.nr, ci.plz, ci.ort FROM customer cu INNER JOIN address a ON cu.fkAddress = a.idAddress INNER JOIN city ci ON a.fkCity = ci.idCity;";

          using (IDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              Customer newCustomer = new Customer(ConvertToInt(reader.GetValue(0)), reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3), reader.GetString(4),
                ConvertToInt(reader.GetValue(5)), reader.GetString(6));
              allCustomers.Add(newCustomer);
            }

            reader.Close();
          }
        }
      }
      finally
      {
        MySqlConnection.Close();
      }

      return (IReadOnlyList<Customer>) allCustomers;
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
  }
}