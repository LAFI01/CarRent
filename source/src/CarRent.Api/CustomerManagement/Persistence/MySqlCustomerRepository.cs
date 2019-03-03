// ************************************************************************************
// FileName: MySqlCustomerRepository.cs
// Author: 
// Created on: 10.02.2019
// Last modified on: 03.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api.CustomerManagement.Persistence
{
  using System.Collections.Generic;
  using System.Data;
  using Common.Persistence;
  using Domain;
  using MySql.Data.MySqlClient;

  public class MySqlCustomerRepository : MySqlBaseRespository, ICustomerRepository
  {
    public MySqlCustomerRepository(string connectionString) : base(connectionString)
    {
    }

    public void CreateCustomer(string name, string firstname, string street, string nr, int plz, string city)
    {
      try
      {
        MySqlConnection.Open();
        IDbCommand cmd = CreateCommand(MySqlConnection, CommandType.StoredProcedure, "p_new_customer");

        MySqlParameter p1 = new MySqlParameter("_name", name);
        p1.Direction = ParameterDirection.Input;
        p1.DbType = DbType.String;

        MySqlParameter p2 = new MySqlParameter("_firstname", firstname);
        p2.Direction = ParameterDirection.Input;
        p2.DbType = DbType.String;

        MySqlParameter p3 = new MySqlParameter("_street", street);
        p3.Direction = ParameterDirection.Input;
        p3.DbType = DbType.String;

        MySqlParameter p4 = new MySqlParameter("_nr", nr);
        p4.Direction = ParameterDirection.Input;
        p4.DbType = DbType.String;

        MySqlParameter p5 = new MySqlParameter("_plz", plz);
        p5.Direction = ParameterDirection.Input;
        p5.DbType = DbType.Int32;

        MySqlParameter p6 = new MySqlParameter("_ort", city);
        p6.Direction = ParameterDirection.Input;
        p6.DbType = DbType.String;

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

    public void DeleteCustomer(int customerId)
    {
      DeleteRow("customer", "idCustomer", customerId);
    }


    public IReadOnlyList<Customer> GetAll()
    {
      IList<Customer> allCustomers = new List<Customer>();
      try
      {
        MySqlConnection.Open();
        using (MySqlConnection.BeginTransaction())
        {
          IDbCommand command = CreateCommand(MySqlConnection, CommandType.Text,
            "SELECT * FROM v_customer;");

          using (IDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              Customer newCustomer = new Customer(
                ConvertToInt(reader.GetValue(0)), reader.GetString(1), reader.GetString(2),
                ConvertToInt(reader.GetValue(3)), ConvertToInt(reader.GetValue(4)),
                reader.GetString(5), reader.GetString(6), ConvertToInt(reader.GetValue(7)),
                ConvertToInt(reader.GetValue(8)), ConvertToInt(reader.GetValue(9)), reader.GetString(10));
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
  }
}